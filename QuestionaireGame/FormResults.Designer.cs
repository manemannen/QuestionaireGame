namespace QuestionaireGame
{
    partial class FormResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResults));
            this.listViewResults = new System.Windows.Forms.ListView();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewResults
            // 
            resources.ApplyResources(this.listViewResults, "listViewResults");
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            // 
            // btnPlayGame
            // 
            resources.ApplyResources(this.btnPlayGame, "btnPlayGame");
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // btnQuit
            // 
            resources.ApplyResources(this.btnQuit, "btnQuit");
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // FormResults
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.listViewResults);
            this.Name = "FormResults";
            this.Load += new System.EventHandler(this.FormResults_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Button btnQuit;
    }
}