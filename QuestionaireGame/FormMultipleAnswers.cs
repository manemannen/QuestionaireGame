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
    public partial class FormMultipleAnswers : Form
    {
        public FormMultipleAnswers()
        {
            InitializeComponent();
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
            else
            {
                MessageBox.Show("Du måste välja ett alternativ");
                return;
            }
            
            // Hide the control
            Hide();
            // Return the control to the game controller.
            GameController gameController = GameController.Instance;
            gameController.ShowNextGameSessionQuestion();
        }

        private void FormMultipleAnswers_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            rbAnswer1.Checked = false;
            rbAnswer2.Checked = false;
            rbAnswer3.Checked = false;
        }
    }
}
