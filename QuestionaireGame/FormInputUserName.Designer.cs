namespace QuestionaireGame
{
    partial class FormInputUserName
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblUserNameHeader = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(146, 74);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Starta spel";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUserNameHeader
            // 
            this.lblUserNameHeader.AutoSize = true;
            this.lblUserNameHeader.Location = new System.Drawing.Point(22, 25);
            this.lblUserNameHeader.Name = "lblUserNameHeader";
            this.lblUserNameHeader.Size = new System.Drawing.Size(52, 13);
            this.lblUserNameHeader.TabIndex = 1;
            this.lblUserNameHeader.Text = "Ditt namn";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(25, 48);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(196, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // FormInputUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 111);
            this.ControlBox = false;
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserNameHeader);
            this.Controls.Add(this.btnPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormInputUserName";
            this.Text = "Ange ditt namn för att spela";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblUserNameHeader;
        private System.Windows.Forms.TextBox txtUserName;
    }
}