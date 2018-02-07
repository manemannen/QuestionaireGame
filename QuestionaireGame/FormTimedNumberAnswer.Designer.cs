namespace QuestionaireGame
{
    partial class FormTimedNumberAnswer
    {
        private TimedNumberAnswerQuestion timedNumberAnswerQuestion;
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
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblTimeLeftHeader = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(16, 49);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(72, 20);
            this.tbAnswer.TabIndex = 15;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(16, 19);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(13, 13);
            this.lblQuestion.TabIndex = 13;
            this.lblQuestion.Text = "?";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(301, 179);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblTimeLeftHeader
            // 
            this.lblTimeLeftHeader.AutoSize = true;
            this.lblTimeLeftHeader.Location = new System.Drawing.Point(16, 83);
            this.lblTimeLeftHeader.Name = "lblTimeLeftHeader";
            this.lblTimeLeftHeader.Size = new System.Drawing.Size(49, 13);
            this.lblTimeLeftHeader.TabIndex = 16;
            this.lblTimeLeftHeader.Text = "Tid kvar:";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(69, 83);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(13, 13);
            this.lblTimeLeft.TabIndex = 17;
            this.lblTimeLeft.Text = "?";
            // 
            // FormTimedNumberAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 233);
            this.ControlBox = false;
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblTimeLeftHeader);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormTimedNumberAnswer";
            this.Text = "Skriv in ett nummer innan tiden tar slut";
            this.Load += new System.EventHandler(this.FormTimedNumberAnswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTimeLeftHeader;
        private System.Windows.Forms.Label lblTimeLeft;


        public void LoadQuestion(TimedNumberAnswerQuestion timedNumberAnswerQuestion)
        {
            this.timedNumberAnswerQuestion = timedNumberAnswerQuestion;
            lblQuestion.Text = timedNumberAnswerQuestion.Question;
            lblTimeLeft.Text = timedNumberAnswerQuestion.CompletionTime.ToString();
            tbAnswer.Text = "";
            tbAnswer.Enabled = true;

            timeLeft = timedNumberAnswerQuestion.CompletionTime;
            timer.Start();
        }
    }
}