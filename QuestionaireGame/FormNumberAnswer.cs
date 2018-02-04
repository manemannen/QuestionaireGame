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
    public partial class FormNumberAnswer : Form
    {
        public FormNumberAnswer()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbAnswer.Text, out int n))
            {

                numberAnswerQuestion.UserAnswer = tbAnswer.Text;
                // Hide the control
                Hide();
                // Return the control to the game controller.
                GameController gameController = GameController.Instance;
                gameController.ShowNextGameSessionQuestion();
            }
            else
            {
                MessageBox.Show("Du måste skriva in en siffra!!!!");
            }
        }

        private void FormNumberAnswer_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
