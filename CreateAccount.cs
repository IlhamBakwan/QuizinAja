using QuizinAjaFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuizinAjaFramework
{
    public partial class CreateAccount : Form
    {
        private QuizinAjaEntities _db = new QuizinAjaEntities();
        public CreateAccount()
        {
            InitializeComponent();
        }
        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username do not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Full name do not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password do not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPassword.Text.Length < 4)
            {
                MessageBox.Show("Password is too short! Password must be at least 4 characters long!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtRetype.Text))
            {
                MessageBox.Show("Please fill the password once again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtRetype.Text != txtPassword.Text)
            {
                MessageBox.Show("The password doesn't match with your password before!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateOfBirth.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("Please enter a valid Date of Birth!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int age = DateTime.Today.Year - dateOfBirth.Value.Year;
            if (dateOfBirth.Value.Date > DateTime.Today.AddYears(-age)) age--;


            try
            {
                var userExists = _db.Users.Any(u => u.Username == txtUsername.Text.Trim());

                if (userExists)
                {
                    MessageBox.Show("Username is already taken. Please choose another one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                User newUser = new User()
                {
                    Username = txtUsername.Text.Trim(),
                    FullName = txtFullName.Text.Trim(),
                    Password = txtPassword.Text,
                    DateOfBirth = dateOfBirth.Value.Date,
                };

                _db.Users.Add(newUser);
                _db.SaveChanges();

                MessageBox.Show("Account successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var _loginForm = new LoginForm();
                _loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var _loginForm = new LoginForm();
            _loginForm.Show();
            this.Close();
        }
    }
}
