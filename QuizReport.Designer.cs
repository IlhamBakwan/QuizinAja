namespace QuizinAjaFramework
{
    partial class QuizReport
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
            this.quizList = new System.Windows.Forms.ComboBox();
            this.lblAvgTime = new System.Windows.Forms.Label();
            this.lblAvgPercentage = new System.Windows.Forms.Label();
            this.lblParticipant = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDetailData = new System.Windows.Forms.DataGridView();
            this.ParticipantNickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorrectPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Quiz Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quiz";
            // 
            // quizList
            // 
            this.quizList.FormattingEnabled = true;
            this.quizList.Location = new System.Drawing.Point(62, 58);
            this.quizList.Name = "quizList";
            this.quizList.Size = new System.Drawing.Size(232, 24);
            this.quizList.TabIndex = 2;
            this.quizList.SelectedIndexChanged += new System.EventHandler(this.quizList_SelectedIndexChanged);
            // 
            // lblAvgTime
            // 
            this.lblAvgTime.AutoSize = true;
            this.lblAvgTime.Location = new System.Drawing.Point(379, 61);
            this.lblAvgTime.Name = "lblAvgTime";
            this.lblAvgTime.Size = new System.Drawing.Size(135, 16);
            this.lblAvgTime.TabIndex = 3;
            this.lblAvgTime.Text = "Average Time Taken";
            // 
            // lblAvgPercentage
            // 
            this.lblAvgPercentage.AutoSize = true;
            this.lblAvgPercentage.Location = new System.Drawing.Point(379, 86);
            this.lblAvgPercentage.Name = "lblAvgPercentage";
            this.lblAvgPercentage.Size = new System.Drawing.Size(178, 16);
            this.lblAvgPercentage.TabIndex = 4;
            this.lblAvgPercentage.Text = "Average Correct Percentage";
            // 
            // lblParticipant
            // 
            this.lblParticipant.AutoSize = true;
            this.lblParticipant.Location = new System.Drawing.Point(379, 112);
            this.lblParticipant.Name = "lblParticipant";
            this.lblParticipant.Size = new System.Drawing.Size(104, 16);
            this.lblParticipant.TabIndex = 5;
            this.lblParticipant.Text = "Total Participant";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDetailData);
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 401);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Data";
            // 
            // dgvDetailData
            // 
            this.dgvDetailData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailData.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDetailData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParticipantNickname,
            this.TimeTaken,
            this.CorrectPercentage});
            this.dgvDetailData.Location = new System.Drawing.Point(6, 21);
            this.dgvDetailData.Name = "dgvDetailData";
            this.dgvDetailData.RowHeadersVisible = false;
            this.dgvDetailData.RowHeadersWidth = 51;
            this.dgvDetailData.RowTemplate.Height = 24;
            this.dgvDetailData.Size = new System.Drawing.Size(764, 374);
            this.dgvDetailData.TabIndex = 0;
            // 
            // ParticipantNickname
            // 
            this.ParticipantNickname.HeaderText = "ParticipantNickname";
            this.ParticipantNickname.MinimumWidth = 6;
            this.ParticipantNickname.Name = "ParticipantNickname";
            // 
            // TimeTaken
            // 
            this.TimeTaken.HeaderText = "TimeTaken";
            this.TimeTaken.MinimumWidth = 6;
            this.TimeTaken.Name = "TimeTaken";
            // 
            // CorrectPercentage
            // 
            this.CorrectPercentage.HeaderText = "CorrectPercentage";
            this.CorrectPercentage.MinimumWidth = 6;
            this.CorrectPercentage.Name = "CorrectPercentage";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(698, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // QuizReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblParticipant);
            this.Controls.Add(this.lblAvgPercentage);
            this.Controls.Add(this.lblAvgTime);
            this.Controls.Add(this.quizList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuizReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizinAjaFramework - Online Quiz Platform";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox quizList;
        private System.Windows.Forms.Label lblAvgTime;
        private System.Windows.Forms.Label lblAvgPercentage;
        private System.Windows.Forms.Label lblParticipant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDetailData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantNickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorrectPercentage;
        private System.Windows.Forms.Button btnBack;
    }
}