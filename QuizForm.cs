using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizinAjaFramework
{
    public partial class QuizForm : Form
    {
        private QuizinAjaEntities _db = new QuizinAjaEntities();
        private int _quizId;
        private string _quizName;
        private string _nickname;
        private List<Question> _questionList = new List<Question>();
        private int _currentQuestionIndex = 0;
        private int _totalSecondsElapsed = 0;
        private Dictionary<int, int> _chosenAnswers = new Dictionary<int, int>();
        public QuizForm(int quizId, string quizName, string nickname)
        {
            InitializeComponent();

            _quizId = quizId;
            _quizName = quizName;
            _nickname = nickname;

            lblNickname.Text = $"Participant: {_nickname}";

            LoadQuestionsFromDatabase();

            timer1.Start();
        }
        private void LoadQuestionsFromDatabase()
        {
            try
            {
                _questionList = _db.Questions.Where(q => q.QuizID == _quizId).ToList();

                if (_questionList.Count == 0)
                {
                    MessageBox.Show("This quiz does not have any questions yet!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }
                DisplayQuestion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load questions: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UpdateQuestionNumberColors();
        }
        private void DisplayQuestion()
        {
            if (_currentQuestionIndex < 0 || _currentQuestionIndex >= _questionList.Count) return;

            var currentQuestion = _questionList[_currentQuestionIndex];

            lblQuestion.Text = $"{_currentQuestionIndex + 1}. {currentQuestion.Question1}";
            opt1.Text = currentQuestion.OptionA;
            opt2.Text = currentQuestion.OptionB;
            opt3.Text = currentQuestion.OptionC;
            opt4.Text = currentQuestion.OptionD;

            ResetRadioButtons();

            if (_chosenAnswers.ContainsKey(currentQuestion.ID))
            {
                int previousOptionNumber = _chosenAnswers[currentQuestion.ID];
                if (previousOptionNumber == 1) opt1.Checked = true;
                else if (previousOptionNumber == 2) opt2.Checked = true;
                else if (previousOptionNumber == 3) opt3.Checked = true;
                else if (previousOptionNumber == 4) opt4.Checked = true;
            }

            if (_currentQuestionIndex == _questionList.Count - 1)
            {
                btnNextSubmit.Text = "Finish";
            }
            else
            {
                btnNextSubmit.Text = "Next";
            }
            UpdateQuestionNumberColors();
        }

        private void UpdateQuestionNumberColors()
        {
            for (int i = 0; i < _questionList.Count; i++)
            {
                var question = _questionList[i];
                string buttonName = $"question{i + 1}";
                Button btnNumber = panel1.Controls.Find(buttonName, true).FirstOrDefault() as Button;

                if (btnNumber != null)
                {
                    if (_chosenAnswers.ContainsKey(question.ID))
                    {
                        btnNumber.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        btnNumber.BackColor = Color.LightGray;
                    }
                }
            }
        }
        private void SaveAnswerState(int optionNumber)
        {
            var currentQuestion = _questionList[_currentQuestionIndex];

            if (_chosenAnswers.ContainsKey(currentQuestion.ID))
                _chosenAnswers[currentQuestion.ID] = optionNumber;
            else
                _chosenAnswers.Add(currentQuestion.ID, optionNumber);
            
            UpdateQuestionNumberColors();
        }
        private void opt1_CheckedChanged(object sender, EventArgs e)
        {
            if (opt1.Checked) SaveAnswerState(1);
        }
        private void opt2_CheckedChanged(object sender, EventArgs e)
        {
            if (opt2.Checked) SaveAnswerState(2);
        }
        private void opt3_CheckedChanged(object sender, EventArgs e)
        {
            if (opt3.Checked) SaveAnswerState(3);
        }
        private void opt4_CheckedChanged(object sender, EventArgs e)
        {
            if (opt4.Checked) SaveAnswerState(4);
        }
        private void ResetRadioButtons()
        {
            opt1.Checked = false;
            opt2.Checked = false;
            opt3.Checked = false;
            opt4.Checked = false;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentQuestionIndex > 0)
            {
                _currentQuestionIndex--;
                DisplayQuestion();
            }
        }
        private void SaveAllQuizAnswer()
        {
            try
            {
                int totalCorrectAnswers = 0;
                foreach (var question in _questionList)
                {
                    if (_chosenAnswers.ContainsKey(question.ID))
                    {
                        int guestChoice = _chosenAnswers[question.ID];
                        string realTextAnswer = "";
                        if (guestChoice == 1) realTextAnswer = question.OptionA;
                        else if (guestChoice == 2) realTextAnswer = question.OptionB;
                        else if (guestChoice == 3) realTextAnswer = question.OptionC;
                        else if (guestChoice == 4) realTextAnswer = question.OptionD;

                        if (realTextAnswer == question.CorrectAnswer)
                        {
                            totalCorrectAnswers++;
                        }
                    }
                }

                var newParticipant = new Participant
                {
                    QuizID = _quizId,
                    ParticipantNickname = _nickname,
                    TimeTaken = _totalSecondsElapsed
                };

                _db.Participants.Add(newParticipant);
                _db.SaveChanges();

                foreach (var question in _questionList)
                {
                    int chosenNumber = _chosenAnswers.ContainsKey(question.ID) ? _chosenAnswers[question.ID] : 0;
                    string actualTextAnswer = "";

                    if (chosenNumber == 1) actualTextAnswer = question.OptionA;
                    else if (chosenNumber == 2) actualTextAnswer = question.OptionB;
                    else if (chosenNumber == 3) actualTextAnswer = question.OptionC;
                    else if (chosenNumber == 4) actualTextAnswer = question.OptionD;

                    var pAnswer = new ParticipantAnswer
                    {
                        ParticipantID = newParticipant.ID,
                        QuestionID = question.ID,
                        Answer = actualTextAnswer
                    };

                    _db.ParticipantAnswers.Add(pAnswer);
                }

                _db.SaveChanges();

                double scorePercentage = ((double)totalCorrectAnswers / _questionList.Count) * 100;

                MessageBox.Show(
                    $"Quiz Finished!\n\n" +
                    $"Correct Answers: {totalCorrectAnswers} of {_questionList.Count}\n" +
                    $"Your Score: {Math.Round(scorePercentage)}%",
                    "Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                var _enterCodeForm = new EnterQuizCode();
                _enterCodeForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save quiz data to database: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNextSubmit_Click(object sender, EventArgs e)
        {
            if (btnNextSubmit.Text == "Next")
            {
                if (_currentQuestionIndex < _questionList.Count - 1)
                {
                    _currentQuestionIndex++;
                    DisplayQuestion();
                }
            }
            else
            {
                SaveAllQuizAnswer();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _totalSecondsElapsed++;

            TimeSpan timeSpan = TimeSpan.FromSeconds(_totalSecondsElapsed);
            string timeFormatted = string.Format("{0:D2}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);

            timeElapsed.Text = $"Time Taken : {timeFormatted}";
        }
    }
}
