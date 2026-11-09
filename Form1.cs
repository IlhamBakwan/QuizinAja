using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuizinAjaFramework
{
    public partial class LoginForm : Form
    {
        private readonly QuizinAjaEntities _db;
        public LoginForm()
        {
            InitializeComponent();
            _db = new QuizinAjaEntities();
            txtUsername.Text = "mahdi";
            txtPassword.Text = "1234";
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            try
            {
                var username = txtUsername.Text;
                var password = txtPassword.Text;

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please enter the username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter the password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    var user = _db.Users.FirstOrDefault(u => u.Username == username);

                    if (user == null)
                    {
                        MessageBox.Show("Email is not registered.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!user.Username.Equals(username, StringComparison.Ordinal))
                    {
                        MessageBox.Show("Username case does not match. Please check your capital letters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!user.Password.Equals(password, StringComparison.Ordinal))
                    {
                        MessageBox.Show("Incorrect password. Please check your capital letters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    var _mainForm = new MainForm(user.FullName, user.ID, this);
                    _mainForm.Show();
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    this.Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkAccount_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var _createAccount = new CreateAccount();
            _createAccount.Show();
            txtUsername.Text = "";
            txtPassword.Text = "";
            this.Hide();
        }
        private void showPswd_CheckedChanged(object sender, EventArgs e)
        {
            if (showPswd.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
        private void linkJoinQuiz_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var _enterQuizCode = new EnterQuizCode();
            _enterQuizCode.Show();
            this.Hide();
        }
    }
}
