using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuizinAjaFramework
{
    public partial class MainForm : Form
    {
        public string name = "";
        public int currentUserId = 0;
        private QuizinAjaEntities _db = new QuizinAjaEntities();
        private LoginForm _loginForm;
        public MainForm(string userName, int loggedInUserId, LoginForm loginForm)
        {
            InitializeComponent();
            name = userName;
            currentUserId = loggedInUserId;
            _loginForm = loginForm;

            txtUserName.Text = name;
            LoadUserQuizzes();
        }

        private void LoadUserQuizzes()
        {
            yourQuiz.Rows.Clear();

            int quizNumber = 1;
            var userQuizzes = _db.Quizs.Where(q => q.UserID == currentUserId).ToList();

            foreach (var quiz in userQuizzes)
            {
                int numberOfQuestions = _db.Questions.Count(quest => quest.QuizID == quiz.ID);
                yourQuiz.Rows.Add(
                    quiz.Name,
                    quiz.Code,
                    quiz.Description,
                    numberOfQuestions,
                    "Delete"
                );
            }
        }

        private void yourQuiz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                string quizCode = yourQuiz.Rows[e.RowIndex].Cells[1].Value.ToString();
                string quizName = yourQuiz.Rows[e.RowIndex].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete the quiz '{quizName}'?",
                    "Delete Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var quizToDelete = _db.Quizs.FirstOrDefault(q => q.Code == quizCode);

                        if (quizToDelete != null)
                        {
                            var relatedQuestions = _db.Questions.Where(quest => quest.QuizID == quizToDelete.ID).ToList();
                            foreach (var question in relatedQuestions)
                            {
                                _db.Questions.Remove(question);
                            }

                            _db.Quizs.Remove(quizToDelete);
                            _db.SaveChanges();

                            MessageBox.Show("Quiz and all its related questions have been successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadUserQuizzes();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to delete data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            _loginForm = new LoginForm();
            _loginForm.Show();
            this.Close();
        }
        private void btnAddQuiz_Click(object sender, EventArgs e)
        {
            var _addQuiz = new AddQuiz(this);
            _addQuiz.Show();
            Hide();
        }
        private void btnQuizReport_Click(object sender, EventArgs e)
        {
            var _quizReport = new QuizReport(this);
            _quizReport.Show();
            Hide();
        }
    }
}
