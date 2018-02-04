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
    public partial class FormTextAnswer : Form
    {
        public FormTextAnswer()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(tbAnswer.Text == "")
            {
                MessageBox.Show("Du måste ge ett svar!");
                return;
            }
            textAnswerQuestion.UserAnswer = tbAnswer.Text;
            // Hide the control
            Hide();
            // Return the control to the game controller.
            GameController gameController = GameController.Instance;
            gameController.ShowNextGameSessionQuestion();
        }

        private void FormTextAnswer_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
