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
    public partial class FormTimedNumberAnswer : Form

    {
        Timer timer = new Timer();
        private int timeLeft;

        public FormTimedNumberAnswer()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(TimerTick);
            timer.Interval = (1000) * (1);
            timer.Enabled = true;
            timer.Start();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            timedNumberAnswerQuestion.UserAnswer = tbAnswer.Text;
            // Hide the control
            Hide();
            // Return the control to the game controller.
            GameController gameController = GameController.Instance;
            gameController.ShowNextGameSessionQuestion();
        }

        void TimerTick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimeLeft.Text = timeLeft.ToString();
            if (timeLeft == 0)
            {
                timer.Stop();
                tbAnswer.Text = "";
                tbAnswer.Enabled = false;
                lblTimeLeft.Text = "U FAILeD NOOOB BOY";
            }
        }

        private void FormTimedNumberAnswer_Load(object sender, EventArgs e)
        {
            this.CenterToScreen(); 
        }
    }
}
