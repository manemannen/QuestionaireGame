using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionaireGame
{
    public partial class FormResults : Form
    {
        private int index;
        private List<Result> results;
        public FormResults()
        {
            InitializeComponent();
        }

        public void SetResults(List<Result> results)
        {
            this.results = results;
            if (results.Count > 0)
            {
                index = results.Count - 1;
            }
            updateButtonStates();
            ShowResult();
           
        }
        private void ShowResult()
        {
            if (results.Count > 0)
            {
                Result result = results.ElementAt<Result>(index);
                List<BaseQuestion> questions = result.Questions;

                lblGameCompletedOn.Text = result.CreatedTime.ToString();
                listViewResults.Clear();
                listViewResults.View = View.Details;
                int i = 0;
                ListViewItem[] items = new ListViewItem[questions.Count()];
                foreach (var q in questions)
                {
                    ListViewItem lvi = new ListViewItem(q.Question);
                    if (q.IsCorrect())
                    {
                        lvi.ForeColor = Color.Green;
                    }
                    else
                    {
                        lvi.ForeColor = Color.Red;
                    }
                    lvi.SubItems.Add(q.Answer);
                    lvi.SubItems.Add(q.UserAnswer);
                    items[i] = lvi;
                    i++;
                }
                // Create columns for the items and subitems.
                // Width of -2 indicates auto-size.
                listViewResults.Columns.Add("Fråga", 350);
                listViewResults.Columns.Add("Rätt svar", 150);
                listViewResults.Columns.Add("Ditt svar", 150);
                listViewResults.Items.AddRange(items);

                lblPlayer.Text = result.UserName;
                lblCompletionTime.Text = result.CompletionTime.ToString();
            }
        }
        
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            // TODO tell the game controller to start a new game
            GameController gameController = GameController.Instance;
            gameController.StartNewGameSession();

            Visible = false;
        }

        private void FormResults_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        /**
         * Updates the Enabled state on the previous and next buttons depending on which result 
         * is currentrly viewed and the number of available results. 
         **/
        private void updateButtonStates()
        {
            btnPrevious.Enabled = !(results.Count == 0 || index <= 0);
            btnNext.Enabled = !(results.Count == 0 || index == results.Count - 1);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            index--;
            updateButtonStates();
            ShowResult();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            index++;
            updateButtonStates();
            ShowResult();
        }

        private void btnShowBestResult_Click(object sender, EventArgs e)
        {
            if (results.Count == 0)
            {
                return;
            }
            int currentBestResult=-1;
            List<Result> bestResults = new List<Result>();
            // get the best result based on correct answers and completion time.
            foreach(Result result in results)
            {
                if (result.GetCorrectAnswers() > currentBestResult)
                {
                    bestResults.Clear();
                    bestResults.Add(result);
                    currentBestResult = result.GetCorrectAnswers();
                }
                else if (result.GetCorrectAnswers() == currentBestResult)
                {
                    bestResults.Add(result);
                    currentBestResult = result.GetCorrectAnswers();
                }
            }
            // we may have many results with the same score. Lets filter on time.
            Result bestResult = null;
            long currentBestResultTime = int.MaxValue;
            foreach(Result result in bestResults)
            {
                if (result.CompletionTime < currentBestResultTime)
                {
                    bestResult = result;
                    currentBestResultTime = result.CompletionTime;
                }
            }
            // get the index of the best result and update the controls.
            index = results.FindIndex(x => x == bestResult);
            updateButtonStates();
            ShowResult();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
