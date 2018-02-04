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

        public void setResults(List<BaseQuestion> questions)
        {
            listViewResults.Clear();
            listViewResults.View = View.Details;
            int i = 0;
            ListViewItem[] items = new ListViewItem[questions.Count()];
            foreach (var q in questions)
            {
                ListViewItem lvi = new ListViewItem(q.Question);
                lvi.SubItems.Add(q.Answer);
                lvi.SubItems.Add(q.UserAnswer);
                items[i] = lvi;
                i++;
            }

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listViewResults.Columns.Add("Question",-2);
            listViewResults.Columns.Add("Correct answer",-2);
            listViewResults.Columns.Add("User answer",-2);
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
    }
}
