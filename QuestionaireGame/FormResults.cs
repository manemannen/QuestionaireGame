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
        public FormResults()
        {
            InitializeComponent();
        }

        public void SetResults(List<BaseQuestion> questions)
        {
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
            listViewResults.Columns.Add("Fråga",350);
            listViewResults.Columns.Add("Rätt svar",150);
            listViewResults.Columns.Add("Ditt svar",150);
            listViewResults.Items.AddRange(items);
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
    }
}
