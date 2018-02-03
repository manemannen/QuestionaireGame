using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace QuestionaireGame
{
    class GameController
    {
        private List<MultipleAnswerQuestion> questions;

        private static GameController instance;

        private GameController() { }

        public static GameController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameController();
                }
                return instance;
            }
        }

        public void PlayGame()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MultipleAnswerQuestion multipleAnswerQuestion = questions.First<MultipleAnswerQuestion>();
            Form3Answers frm = new Form3Answers();

            frm.LoadQuestion(multipleAnswerQuestion);


            Application.Run(frm);
        }


        public void InitGame()
        {
            LoadJson();
        }

        private void LoadJson()
        {
            using (StreamReader r = new StreamReader("..\\..\\MultipleAnswerQuestions.json"))
            {
                string json = r.ReadToEnd();
                questions = JsonConvert.DeserializeObject<List<MultipleAnswerQuestion>>(json);

                foreach (var q in questions)
                {
                    Console.WriteLine("Question is {0}", q.Question);
                }
            }
        }

        public void FormCompleted()
        {
            CheckAnswers();
        }
        private void CheckAnswers()
        {
            foreach (var q in questions)
            {
                Console.WriteLine("Correct answer is {0}, your answer is {1}.", q.Answer, q.UserAnswer);
            }
            FormReults formReults = new FormReults();
            formReults.setResults(questions);
            formReults.ShowDialog();
        }


    }
}
