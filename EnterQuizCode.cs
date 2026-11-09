using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuizinAjaFramework
{
    public partial class EnterQuizCode : Form
    {
        private QuizinAjaEntities _db = new QuizinAjaEntities();
        public EnterQuizCode()
        {
            InitializeComponent();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            try
            {
                string inputCode = txtQuizCode.Text.Trim().ToUpper();
                string nickname = txtNickname.Text.Trim().ToUpper();

                if (inputCode == null)
                {
                    MessageBox.Show("Please enter the quiz code.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (nickname == null)
                {
                    MessageBox.Show("Please enter the nickname.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    var selectedQuiz = _db.Quizs.FirstOrDefault(q => q.Code == inputCode);

                    if (selectedQuiz == null)
                    {
                        MessageBox.Show("Invalid quiz code! The quiz does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int quizId = selectedQuiz.ID;
                    string quizName = selectedQuiz.Name;

                    var _quizForm = new QuizForm(quizId, quizName, txtNickname.Text.Trim());
                    _quizForm.Show();
                    this.Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {

            }
        }
    }
}
