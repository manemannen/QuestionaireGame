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
    public partial class Form3Answers : Form
    {
        public Form3Answers()
        {
            InitializeComponent();
        }

        private void frm3Answers_Load(object sender, EventArgs e)
        {
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(rbAnswer1.Checked)
            {
                multipleAnswerQuestion.UserAnswer = rbAnswer1.Text;
            }
            else if (rbAnswer2.Checked)
            {
                multipleAnswerQuestion.UserAnswer = rbAnswer2.Text;
            }
            else if (rbAnswer3.Checked)
            {
                multipleAnswerQuestion.UserAnswer = rbAnswer3.Text;
            }
            Close();
        }

        protected void FormClosedHandler(object sender, FormClosedEventArgs args)
        {
            GameController gameController = GameController.Instance;
            gameController.FormCompleted();
        }

    }
}
