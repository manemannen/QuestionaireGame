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
    public partial class FormReults : Form
    {
        public FormReults()
        {
            InitializeComponent();
        }

        private void FormResults_Load(object sender, EventArgs e)
        {

        }

        public void setResults(List<MultipleAnswerQuestion> questions)
        {
            listViewResults.View = View.Details;
            int i = 0;
            ListViewItem[] items = new ListViewItem[3];
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
            listViewResults.Columns.Add("Question");
            listViewResults.Columns.Add("Correct answer");
            listViewResults.Columns.Add("User answer");
            listViewResults.Items.AddRange(items);
        }
    }
}
