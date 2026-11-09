namespace QuizinAjaFramework
{
    partial class QuizForm
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
            this.components = new System.ComponentModel.Container();
            this.lblNickname = new System.Windows.Forms.Label();
            this.timeElapsed = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.question5 = new System.Windows.Forms.Button();
            this.question4 = new System.Windows.Forms.Button();
            this.question3 = new System.Windows.Forms.Button();
            this.question2 = new System.Windows.Forms.Button();
            this.question1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNextSubmit = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.opt4 = new System.Windows.Forms.RadioButton();
            this.opt3 = new System.Windows.Forms.RadioButton();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickname.Location = new System.Drawing.Point(12, 22);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(157, 25);
            this.lblNickname.TabIndex = 0;
            this.lblNickname.Text = "[Nickname123]";
            // 
            // timeElapsed
            // 
            this.timeElapsed.AutoSize = true;
            this.timeElapsed.Location = new System.Drawing.Point(14, 56);
            this.timeElapsed.Name = "timeElapsed";
            this.timeElapsed.Size = new System.Drawing.Size(91, 16);
            this.timeElapsed.TabIndex = 1;
            this.timeElapsed.Text = "Time elapsed";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.question5);
            this.panel1.Controls.Add(this.question4);
            this.panel1.Controls.Add(this.question3);
            this.panel1.Controls.Add(this.question2);
            this.panel1.Controls.Add(this.question1);
            this.panel1.Location = new System.Drawing.Point(17, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 311);
            this.panel1.TabIndex = 2;
            // 
            // question5
            // 
            this.question5.Location = new System.Drawing.Point(223, 23);
            this.question5.Name = "question5";
            this.question5.Size = new System.Drawing.Size(46, 45);
            this.question5.TabIndex = 4;
            this.question5.Text = "5";
            this.question5.UseVisualStyleBackColor = true;
            // 
            // question4
            // 
            this.question4.Location = new System.Drawing.Point(177, 23);
            this.question4.Name = "question4";
            this.question4.Size = new System.Drawing.Size(46, 45);
            this.question4.TabIndex = 3;
            this.question4.Text = "4";
            this.question4.UseVisualStyleBackColor = true;
            // 
            // question3
            // 
            this.question3.Location = new System.Drawing.Point(131, 23);
            this.question3.Name = "question3";
            this.question3.Size = new System.Drawing.Size(46, 45);
            this.question3.TabIndex = 2;
            this.question3.Text = "3";
            this.question3.UseVisualStyleBackColor = true;
            // 
            // question2
            // 
            this.question2.Location = new System.Drawing.Point(85, 23);
            this.question2.Name = "question2";
            this.question2.Size = new System.Drawing.Size(46, 45);
            this.question2.TabIndex = 1;
            this.question2.Text = "2";
            this.question2.UseVisualStyleBackColor = true;
            // 
            // question1
            // 
            this.question1.Location = new System.Drawing.Point(39, 23);
            this.question1.Name = "question1";
            this.question1.Size = new System.Drawing.Size(46, 45);
            this.question1.TabIndex = 0;
            this.question1.Text = "1";
            this.question1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnNextSubmit);
            this.panel2.Controls.Add(this.btnPrev);
            this.panel2.Controls.Add(this.opt4);
            this.panel2.Controls.Add(this.opt3);
            this.panel2.Controls.Add(this.opt2);
            this.panel2.Controls.Add(this.opt1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblQuestion);
            this.panel2.Location = new System.Drawing.Point(339, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 441);
            this.panel2.TabIndex = 3;
            // 
            // btnNextSubmit
            // 
            this.btnNextSubmit.Location = new System.Drawing.Point(323, 397);
            this.btnNextSubmit.Name = "btnNextSubmit";
            this.btnNextSubmit.Size = new System.Drawing.Size(120, 30);
            this.btnNextSubmit.TabIndex = 7;
            this.btnNextSubmit.Text = "Next";
            this.btnNextSubmit.UseVisualStyleBackColor = true;
            this.btnNextSubmit.Click += new System.EventHandler(this.btnNextSubmit_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(12, 397);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(120, 30);
            this.btnPrev.TabIndex = 6;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // opt4
            // 
            this.opt4.AutoSize = true;
            this.opt4.Location = new System.Drawing.Point(25, 300);
            this.opt4.Name = "opt4";
            this.opt4.Size = new System.Drawing.Size(62, 20);
            this.opt4.TabIndex = 5;
            this.opt4.TabStop = true;
            this.opt4.Text = "[opt4]";
            this.opt4.UseVisualStyleBackColor = true;
            // 
            // opt3
            // 
            this.opt3.AutoSize = true;
            this.opt3.Location = new System.Drawing.Point(25, 274);
            this.opt3.Name = "opt3";
            this.opt3.Size = new System.Drawing.Size(62, 20);
            this.opt3.TabIndex = 4;
            this.opt3.TabStop = true;
            this.opt3.Text = "[opt3]";
            this.opt3.UseVisualStyleBackColor = true;
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.Location = new System.Drawing.Point(25, 248);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(62, 20);
            this.opt2.TabIndex = 3;
            this.opt2.TabStop = true;
            this.opt2.Text = "[opt2]";
            this.opt2.UseVisualStyleBackColor = true;
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.Location = new System.Drawing.Point(25, 222);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(62, 20);
            this.opt1.TabIndex = 2;
            this.opt1.TabStop = true;
            this.opt1.Text = "[opt1]";
            this.opt1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Answer";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(22, 22);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(68, 16);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "[Question]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Question List";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.timeElapsed);
            this.Controls.Add(this.lblNickname);
            this.Name = "QuizForm";
            this.Text = "QuizinAja - Online Quiz Platform";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Label timeElapsed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button question5;
        private System.Windows.Forms.Button question4;
        private System.Windows.Forms.Button question3;
        private System.Windows.Forms.Button question2;
        private System.Windows.Forms.Button question1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNextSubmit;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.RadioButton opt4;
        private System.Windows.Forms.RadioButton opt3;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}