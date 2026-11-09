using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuizinAjaFramework
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.Label();
            this.yourQuiz = new System.Windows.Forms.DataGridView();
            this.QuizName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddQuiz = new System.Windows.Forms.Button();
            this.btnQuizReport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yourQuiz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(12, 30);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(172, 41);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "User Name";
            // 
            // yourQuiz
            // 
            this.yourQuiz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.yourQuiz.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.yourQuiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yourQuiz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuizName,
            this.Code,
            this.Description,
            this.colNumQuestion,
            this.Delete});
            this.yourQuiz.GridColor = System.Drawing.SystemColors.Menu;
            this.yourQuiz.Location = new System.Drawing.Point(240, 30);
            this.yourQuiz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yourQuiz.Name = "yourQuiz";
            this.yourQuiz.RowHeadersVisible = false;
            this.yourQuiz.RowHeadersWidth = 51;
            this.yourQuiz.Size = new System.Drawing.Size(625, 406);
            this.yourQuiz.TabIndex = 3;
            this.yourQuiz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.yourQuiz_CellContentClick);
            // 
            // QuizName
            // 
            this.QuizName.HeaderText = "QuizName";
            this.QuizName.MinimumWidth = 6;
            this.QuizName.Name = "QuizName";
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // colNumQuestion
            // 
            this.colNumQuestion.HeaderText = "NumberOfQuestion";
            this.colNumQuestion.MinimumWidth = 6;
            this.colNumQuestion.Name = "colNumQuestion";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your Quiz";
            // 
            // btnAddQuiz
            // 
            this.btnAddQuiz.Location = new System.Drawing.Point(33, 139);
            this.btnAddQuiz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddQuiz.Name = "btnAddQuiz";
            this.btnAddQuiz.Size = new System.Drawing.Size(180, 32);
            this.btnAddQuiz.TabIndex = 5;
            this.btnAddQuiz.Text = "Add Quiz";
            this.btnAddQuiz.UseVisualStyleBackColor = true;
            this.btnAddQuiz.Click += new System.EventHandler(this.btnAddQuiz_Click);
            // 
            // btnQuizReport
            // 
            this.btnQuizReport.Location = new System.Drawing.Point(33, 189);
            this.btnQuizReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuizReport.Name = "btnQuizReport";
            this.btnQuizReport.Size = new System.Drawing.Size(180, 32);
            this.btnQuizReport.TabIndex = 6;
            this.btnQuizReport.Text = "View Quiz Report";
            this.btnQuizReport.UseVisualStyleBackColor = true;
            this.btnQuizReport.Click += new System.EventHandler(this.btnQuizReport_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(33, 425);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 31);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 467);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnQuizReport);
            this.Controls.Add(this.btnAddQuiz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yourQuiz);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizinAja - Online Quiz Platform";
            ((System.ComponentModel.ISupportInitialize)(this.yourQuiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label txtUserName;
        private DataGridView yourQuiz;
        private Label label3;
        private Button btnAddQuiz;
        private Button btnQuizReport;
        private Button btnLogout;
        private DataGridViewTextBoxColumn QuizName;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn colNumQuestion;
        private DataGridViewButtonColumn Delete;
    }
}