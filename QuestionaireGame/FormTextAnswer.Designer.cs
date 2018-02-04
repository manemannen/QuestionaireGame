namespace QuestionaireGame
{
    partial class FormTextAnswer
    {
        private TextAnswerQuestion textAnswerQuestion;
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(14, 90);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(361, 20);
            this.tbAnswer.TabIndex = 8;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(303, 195);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(14, 46);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(178, 13);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Denna kommer att laddas dynamiskt";
            // 
            // FormTextAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 233);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnOk);
            this.Name = "FormTextAnswer";
            this.Text = "Skriv in rätt svar";
            this.Load += new System.EventHandler(this.FormTextAnswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblQuestion;

        public void LoadQuestion(TextAnswerQuestion textAnswerQuestion)
        {
            this.textAnswerQuestion = textAnswerQuestion;
            lblQuestion.Text = textAnswerQuestion.Question;
            tbAnswer.Text = "";
        }
    }
}