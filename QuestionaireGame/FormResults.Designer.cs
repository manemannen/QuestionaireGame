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
            this.lblGameCompletedOnHeader = new System.Windows.Forms.Label();
            this.lblGameCompletedOn = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnShowBestResult = new System.Windows.Forms.Button();
            this.lblPlayerHeader = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblCompletionTimeHeader = new System.Windows.Forms.Label();
            this.lblCompletionTime = new System.Windows.Forms.Label();
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
            // lblGameCompletedOnHeader
            // 
            resources.ApplyResources(this.lblGameCompletedOnHeader, "lblGameCompletedOnHeader");
            this.lblGameCompletedOnHeader.Name = "lblGameCompletedOnHeader";
            // 
            // lblGameCompletedOn
            // 
            resources.ApplyResources(this.lblGameCompletedOn, "lblGameCompletedOn");
            this.lblGameCompletedOn.Name = "lblGameCompletedOn";
            // 
            // btnPrevious
            // 
            resources.ApplyResources(this.btnPrevious, "btnPrevious");
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnShowBestResult
            // 
            resources.ApplyResources(this.btnShowBestResult, "btnShowBestResult");
            this.btnShowBestResult.Name = "btnShowBestResult";
            this.btnShowBestResult.UseVisualStyleBackColor = true;
            this.btnShowBestResult.Click += new System.EventHandler(this.btnShowBestResult_Click);
            // 
            // lblPlayerHeader
            // 
            resources.ApplyResources(this.lblPlayerHeader, "lblPlayerHeader");
            this.lblPlayerHeader.Name = "lblPlayerHeader";
            // 
            // lblPlayer
            // 
            resources.ApplyResources(this.lblPlayer, "lblPlayer");
            this.lblPlayer.Name = "lblPlayer";
            // 
            // lblCompletionTimeHeader
            // 
            resources.ApplyResources(this.lblCompletionTimeHeader, "lblCompletionTimeHeader");
            this.lblCompletionTimeHeader.Name = "lblCompletionTimeHeader";
            // 
            // lblCompletionTime
            // 
            resources.ApplyResources(this.lblCompletionTime, "lblCompletionTime");
            this.lblCompletionTime.Name = "lblCompletionTime";
            // 
            // FormResults
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.lblCompletionTime);
            this.Controls.Add(this.lblCompletionTimeHeader);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblPlayerHeader);
            this.Controls.Add(this.btnShowBestResult);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblGameCompletedOn);
            this.Controls.Add(this.lblGameCompletedOnHeader);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.listViewResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormResults";
            this.Load += new System.EventHandler(this.FormResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblGameCompletedOnHeader;
        private System.Windows.Forms.Label lblGameCompletedOn;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnShowBestResult;
        private System.Windows.Forms.Label lblPlayerHeader;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblCompletionTimeHeader;
        private System.Windows.Forms.Label lblCompletionTime;
    }
}