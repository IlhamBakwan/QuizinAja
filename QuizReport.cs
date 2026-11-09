using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuizinAjaFramework
{
    public partial class QuizReport : Form
    {
        private QuizinAjaEntities _db = new QuizinAjaEntities();
        private MainForm _mainform;
        public QuizReport(MainForm mainForm)
        {
            InitializeComponent();
            _mainform = mainForm;

            LoadQuizComboBox();
        }
        private void LoadQuizComboBox()
        {
            try
            {
                quizList.SelectedIndexChanged -= quizList_SelectedIndexChanged;

                var userQuizzes = _db.Quizs
                                     .Where(q => q.UserID == _mainform.currentUserId)
                                     .ToList();

                quizList.DataSource = userQuizzes;
                quizList.DisplayMember = "Name";
                quizList.ValueMember = "ID";
                quizList.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat daftar kuis: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                quizList.SelectedIndexChanged += quizList_SelectedIndexChanged;
            }
        }
        private void quizList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (quizList.SelectedValue == null || quizList.SelectedIndex == -1) return;
            if (!int.TryParse(quizList.SelectedValue.ToString(), out int selectedQuizId)) return;

            dgvDetailData.Rows.Clear();

            int totalParticipants = _db.Participants.Count(p => p.QuizID == selectedQuizId);
            int totalQuestions = _db.Questions.Count(quest => quest.QuizID == selectedQuizId);

            if (totalParticipants == 0 || totalQuestions == 0)
            {
                lblAvgTime.Text = "Average Time Taken : 00:00:00";
                lblAvgPercentage.Text = "Average Correct Percentage : 0%";
                lblParticipant.Text = "Total Participant : 0 participant(s)";
                return;
            }

            try
            {
                double sumPercentage = 0;
                var participantList = _db.Participants.Where(p => p.QuizID == selectedQuizId).ToList();

                foreach (var participant in participantList)
                {
                    int correctAnswers = _db.ParticipantAnswers.Count(pa =>
                        pa.ParticipantID == participant.ID &&
                        pa.Answer == _db.Questions.FirstOrDefault(quest => quest.ID == pa.QuestionID).CorrectAnswer
                    );

                    double participantPercentage = ((double)correctAnswers / totalQuestions) * 100;
                    sumPercentage += participantPercentage;

                    TimeSpan pTimeSpan = TimeSpan.FromSeconds(participant.TimeTaken);
                    string pTimeText = string.Format("{0:D2}:{1:D2}:{2:D2}", pTimeSpan.Hours, pTimeSpan.Minutes, pTimeSpan.Seconds);

                    dgvDetailData.Rows.Add(
                        participant.ParticipantNickname,
                        pTimeText,
                        $"{Math.Round(participantPercentage)}%"
                    );
                }

                double avgSeconds = _db.Participants.Where(p => p.QuizID == selectedQuizId).Average(p => p.TimeTaken);
                TimeSpan totalAvgTime = TimeSpan.FromSeconds(avgSeconds);
                string avgTimeText = string.Format("{0:D2}:{1:D2}:{2:D2}", totalAvgTime.Hours, totalAvgTime.Minutes, totalAvgTime.Seconds);

                double totalAvgPercentage = sumPercentage / totalParticipants;

                lblAvgTime.Text = $"Average Time Taken : {avgTimeText}";
                lblAvgPercentage.Text = $"Average Correct Percentage : {Math.Round(totalAvgPercentage)}%";
                lblParticipant.Text = $"Total Participant : {totalParticipants} participant(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed at loading: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (_mainform != null)
            {
                _mainform.Show();
                this.Close();
            }

        }
    }
}

