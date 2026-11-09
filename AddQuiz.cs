using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace QuizinAjaFramework
{
    public partial class AddQuiz : Form
    {
        private QuizinAjaEntities _db = new QuizinAjaEntities();
        private MainForm _mainform;

        public AddQuiz(MainForm mainform)
        {
            InitializeComponent();
            _mainform = mainform;
            txtQuizCode.CharacterCasing = CharacterCasing.Upper;
            quizList.AllowUserToAddRows = false;
            DeleteButton.UseColumnTextForButtonValue = true;
            DeleteButton.Text = "Delete";
            quizList.CellContentClick += quizList_CellContentClick;
        }

        private void quizList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this question?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    quizList.Rows.RemoveAt(e.RowIndex);

                    for (int i = 0; i < quizList.Rows.Count; i++)
                    {
                        quizList.Rows[i].Cells[0].Value = i + 1;
                    }
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_mainform != null)
            {
                _mainform.Show();
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int selectionStart = txtQuizCode.SelectionStart;

            string cleanText = "";
            foreach (char c in txtQuizCode.Text)
            {
                if (char.IsLetterOrDigit(c))
                {
                    cleanText += char.ToUpper(c);
                }
            }
            if (txtQuizCode.Text != cleanText)
            {
                txtQuizCode.Text = cleanText;
                txtQuizCode.SelectionStart = selectionStart;
            }

            if (quizList.Rows.Count == 0)
            {
                MessageBox.Show("A quiz must have at least one question before it can be saved!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cleanCode = "";
            foreach (char c in txtQuizCode.Text)
            {
                if (char.IsLetterOrDigit(c))
                    cleanCode += char.ToUpper(c);
            }

            if (cleanCode.Length < 3 || cleanCode.Length > 10)
            {
                MessageBox.Show("Invalid quiz code! It must be a combination of uppercase letters and numbers (3–10 characters).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool isCodeExist = _db.Quizs.Any(q => q.Code == cleanCode);
                if (isCodeExist)
                {
                    MessageBox.Show("The quiz code is already being used by another quiz! Please find a different, unique code.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtQuizName.Text) ||
                    string.IsNullOrWhiteSpace(txtQuizCode.Text) ||
                    string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Quiz name, quiz code, and quiz description must be filled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newQuiz = new Quiz
                {
                    Name = txtQuizName.Text.Trim(),
                    Code = cleanCode,
                    Description = txtDescription.Text.Trim(),
                    CreatedAt = DateTime.Now,
                    UserID = 1
                };

                _db.Quizs.Add(newQuiz);
                _db.SaveChanges();

                foreach (DataGridViewRow row in quizList.Rows)
                {
                    if (row.IsNewRow) continue;

                    string optA = row.Cells[2].Value.ToString();
                    string optB = row.Cells[3].Value.ToString();
                    string optC = row.Cells[4].Value.ToString();
                    string optD = row.Cells[5].Value.ToString();
                    string codeAnswer = row.Cells[6].Value.ToString();

                    string realCorrectAnswer = "";
                    if (codeAnswer == "A") realCorrectAnswer = optA;
                    else if (codeAnswer == "B") realCorrectAnswer = optB;
                    else if (codeAnswer == "C") realCorrectAnswer = optC;
                    else if (codeAnswer == "D") realCorrectAnswer = optD;
                    else realCorrectAnswer = codeAnswer;

                    var newQuestion = new Question
                    {
                        QuizID = newQuiz.ID,
                        Question1 = row.Cells[1].Value.ToString(),
                        OptionA = optA,
                        OptionB = optB,
                        OptionC = optC,
                        OptionD = optD,
                        CorrectAnswer = realCorrectAnswer
                    };

                    _db.Questions.Add(newQuestion);
                }

                _db.SaveChanges();

                MessageBox.Show($"The quiz '{newQuiz.Name}' and all its questions have been successfully saved to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (_mainform != null)
                {
                    _mainform.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save data due to a system issue: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuestion.Text) ||
                string.IsNullOrWhiteSpace(txtA.Text) ||
                string.IsNullOrWhiteSpace(txtB.Text) ||
                string.IsNullOrWhiteSpace(txtC.Text) ||
                string.IsNullOrWhiteSpace(txtD.Text))
            {
                MessageBox.Show("All columns must be filled!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string correctAnswer = "";
            if (btnA.Checked) correctAnswer = "A";
            else if (btnB.Checked) correctAnswer = "B";
            else if (btnC.Checked) correctAnswer = "C";
            else if (btnD.Checked) correctAnswer = "D";

            if (string.IsNullOrEmpty(correctAnswer))
            {
                MessageBox.Show("Pick a correct option!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int questionNumber = quizList.Rows.Count + 1;
            quizList.Rows.Add(
                questionNumber,
                txtQuestion.Text.Trim(),
                txtA.Text.Trim(),
                txtB.Text.Trim(),
                txtC.Text.Trim(),
                txtD.Text.Trim(),
                correctAnswer,
                ""
            );

            txtQuestion.Clear();
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtD.Clear();

            btnA.Checked = false;
            btnB.Checked = false;
            btnC.Checked = false;
            btnD.Checked = false;

            txtQuestion.Focus();
        }
    }
}
