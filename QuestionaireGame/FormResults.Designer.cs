namespace QuestionaireGame
{
    partial class FormReults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReults));
            this.listViewResults = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewResults
            // 
            resources.ApplyResources(this.listViewResults, "listViewResults");
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            // 
            // FormReults
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewResults);
            this.Name = "FormReults";
            this.Load += new System.EventHandler(this.FormResults_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewResults;
    }
}