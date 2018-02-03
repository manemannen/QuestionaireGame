namespace QuestionaireGame
{
    partial class Form3Answers
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

        protected MultipleAnswerQuestion multipleAnswerQuestion;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FormClosed += FormClosedHandler;

            this.lblQuestion = new System.Windows.Forms.Label();
            this.rbAnswer1 = new System.Windows.Forms.RadioButton();
            this.rbAnswer2 = new System.Windows.Forms.RadioButton();
            this.rbAnswer3 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(12, 17);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(178, 13);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Denna kommer att laddas dynamiskt";
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // rbAnswer1
            // 
            this.rbAnswer1.AutoSize = true;
            this.rbAnswer1.Location = new System.Drawing.Point(12, 10);
            this.rbAnswer1.Name = "rbAnswer1";
            this.rbAnswer1.Size = new System.Drawing.Size(85, 17);
            this.rbAnswer1.TabIndex = 0;
            this.rbAnswer1.TabStop = true;
            this.rbAnswer1.Text = "radioButton1";
            this.rbAnswer1.UseVisualStyleBackColor = true;
            // 
            // rbAnswer2
            // 
            this.rbAnswer2.AutoSize = true;
            this.rbAnswer2.Location = new System.Drawing.Point(12, 34);
            this.rbAnswer2.Name = "rbAnswer2";
            this.rbAnswer2.Size = new System.Drawing.Size(85, 17);
            this.rbAnswer2.TabIndex = 1;
            this.rbAnswer2.TabStop = true;
            this.rbAnswer2.Text = "radioButton2";
            this.rbAnswer2.UseVisualStyleBackColor = true;
            // 
            // rbAnswer3
            // 
            this.rbAnswer3.AutoSize = true;
            this.rbAnswer3.Location = new System.Drawing.Point(12, 58);
            this.rbAnswer3.Name = "rbAnswer3";
            this.rbAnswer3.Size = new System.Drawing.Size(85, 17);
            this.rbAnswer3.TabIndex = 2;
            this.rbAnswer3.TabStop = true;
            this.rbAnswer3.Text = "radioButton3";
            this.rbAnswer3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbAnswer3);
            this.panel1.Controls.Add(this.rbAnswer2);
            this.panel1.Controls.Add(this.rbAnswer1);
            this.panel1.Location = new System.Drawing.Point(15, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 91);
            this.panel1.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(301, 194);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form3Answers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 233);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Form3Answers";
            this.Text = "Välj ett svarsalternativ";
            this.Load += new System.EventHandler(this.frm3Answers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rbAnswer1;
        private System.Windows.Forms.RadioButton rbAnswer2;
        private System.Windows.Forms.RadioButton rbAnswer3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;

        public void LoadQuestion(MultipleAnswerQuestion multipleAnswerQuestion)
        {
            this.multipleAnswerQuestion = multipleAnswerQuestion;
            lblQuestion.Text = multipleAnswerQuestion.Question;
            rbAnswer1.Text = multipleAnswerQuestion.AnswerOption1;
            rbAnswer2.Text = multipleAnswerQuestion.AnswerOption2;
            rbAnswer3.Text = multipleAnswerQuestion.AnswerOption3;
        }
    }
}

