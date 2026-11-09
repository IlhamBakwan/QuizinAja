using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace QuizinAjaFramework
{
    partial class AddQuiz
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quizList = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorrectAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnA = new System.Windows.Forms.RadioButton();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.RadioButton();
            this.btnD = new System.Windows.Forms.RadioButton();
            this.btnB = new System.Windows.Forms.RadioButton();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtQuizName = new System.Windows.Forms.TextBox();
            this.txtQuizCode = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Quiz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fill in the quiz detail below";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quiz Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quiz Description";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quizList);
            this.groupBox1.Controls.Add(this.btnA);
            this.groupBox1.Controls.Add(this.btnAddQuestion);
            this.groupBox1.Controls.Add(this.txtD);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.btnC);
            this.groupBox1.Controls.Add(this.btnD);
            this.groupBox1.Controls.Add(this.btnB);
            this.groupBox1.Controls.Add(this.txtQuestion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 165);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(956, 332);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question Data";
            // 
            // quizList
            // 
            this.quizList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.quizList.BackgroundColor = System.Drawing.Color.White;
            this.quizList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quizList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.QuestionText,
            this.OptionA,
            this.OptionB,
            this.OptionC,
            this.OptionD,
            this.CorrectAnswer,
            this.DeleteButton});
            this.quizList.GridColor = System.Drawing.Color.White;
            this.quizList.Location = new System.Drawing.Point(6, 154);
            this.quizList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quizList.Name = "quizList";
            this.quizList.RowHeadersVisible = false;
            this.quizList.RowHeadersWidth = 51;
            this.quizList.Size = new System.Drawing.Size(944, 174);
            this.quizList.TabIndex = 27;
            // 
            // Number
            // 
            this.Number.HeaderText = "No.";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            // 
            // QuestionText
            // 
            this.QuestionText.HeaderText = "Question";
            this.QuestionText.MinimumWidth = 6;
            this.QuestionText.Name = "QuestionText";
            // 
            // OptionA
            // 
            this.OptionA.HeaderText = "OptionA";
            this.OptionA.MinimumWidth = 6;
            this.OptionA.Name = "OptionA";
            // 
            // OptionB
            // 
            this.OptionB.HeaderText = "OptionB";
            this.OptionB.MinimumWidth = 6;
            this.OptionB.Name = "OptionB";
            // 
            // OptionC
            // 
            this.OptionC.HeaderText = "OptionC";
            this.OptionC.MinimumWidth = 6;
            this.OptionC.Name = "OptionC";
            // 
            // OptionD
            // 
            this.OptionD.HeaderText = "OptionD";
            this.OptionD.MinimumWidth = 6;
            this.OptionD.Name = "OptionD";
            // 
            // CorrectAnswer
            // 
            this.CorrectAnswer.HeaderText = "CorrectAnswer";
            this.CorrectAnswer.MinimumWidth = 6;
            this.CorrectAnswer.Name = "CorrectAnswer";
            // 
            // DeleteButton
            // 
            this.DeleteButton.HeaderText = "Delete";
            this.DeleteButton.MinimumWidth = 6;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnA
            // 
            this.btnA.AutoSize = true;
            this.btnA.Location = new System.Drawing.Point(352, 41);
            this.btnA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(17, 16);
            this.btnA.TabIndex = 26;
            this.btnA.TabStop = true;
            this.btnA.UseVisualStyleBackColor = true;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(622, 34);
            this.btnAddQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(117, 23);
            this.btnAddQuestion.TabIndex = 25;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(375, 112);
            this.txtD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(211, 22);
            this.txtD.TabIndex = 23;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(375, 87);
            this.txtC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(211, 22);
            this.txtC.TabIndex = 22;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(375, 62);
            this.txtB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(211, 22);
            this.txtB.TabIndex = 20;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(375, 38);
            this.txtA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(211, 22);
            this.txtA.TabIndex = 19;
            // 
            // btnC
            // 
            this.btnC.AutoSize = true;
            this.btnC.Location = new System.Drawing.Point(352, 90);
            this.btnC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(17, 16);
            this.btnC.TabIndex = 18;
            this.btnC.TabStop = true;
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            this.btnD.AutoSize = true;
            this.btnD.Location = new System.Drawing.Point(352, 116);
            this.btnD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(17, 16);
            this.btnD.TabIndex = 17;
            this.btnD.TabStop = true;
            this.btnD.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            this.btnB.AutoSize = true;
            this.btnB.Location = new System.Drawing.Point(352, 65);
            this.btnB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(17, 16);
            this.btnB.TabIndex = 15;
            this.btnB.TabStop = true;
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(6, 37);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestion.Size = new System.Drawing.Size(328, 98);
            this.txtQuestion.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Answer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Question";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(763, 503);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(874, 503);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quiz Code";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(324, 79);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(644, 68);
            this.txtDescription.TabIndex = 13;
            // 
            // txtQuizName
            // 
            this.txtQuizName.Location = new System.Drawing.Point(12, 79);
            this.txtQuizName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuizName.Name = "txtQuizName";
            this.txtQuizName.Size = new System.Drawing.Size(300, 22);
            this.txtQuizName.TabIndex = 14;
            // 
            // txtQuizCode
            // 
            this.txtQuizCode.Location = new System.Drawing.Point(12, 122);
            this.txtQuizCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuizCode.Name = "txtQuizCode";
            this.txtQuizCode.Size = new System.Drawing.Size(300, 22);
            this.txtQuizCode.TabIndex = 15;
            // 
            // AddQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 536);
            this.Controls.Add(this.txtQuizCode);
            this.Controls.Add(this.txtQuizName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizinAjaFramework - Online Quiz Platform";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnSave;
        private Button btnCancel;
        private Label label7;
        private Label label6;
        private Label label4;
        private RadioButton btnD;
        private RadioButton btnB;
        private TextBox txtQuestion;
        private RadioButton btnC;
        private TextBox txtC;
        private TextBox txtB;
        private TextBox txtA;
        private TextBox txtD;
        private Button btnAddQuestion;
        private TextBox txtDescription;
        private RadioButton btnA;
        private TextBox txtQuizName;
        private TextBox txtQuizCode;
        private DataGridView quizList;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn QuestionText;
        private DataGridViewTextBoxColumn OptionA;
        private DataGridViewTextBoxColumn OptionB;
        private DataGridViewTextBoxColumn OptionC;
        private DataGridViewTextBoxColumn OptionD;
        private DataGridViewTextBoxColumn CorrectAnswer;
        private DataGridViewButtonColumn DeleteButton;
    }
}