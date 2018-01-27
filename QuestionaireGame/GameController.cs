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

        public void PlayGame()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            MultipleAnswerQuestion multipleAnswerQuestion = questions.First<MultipleAnswerQuestion>();
            frm3Answers frm = new frm3Answers();
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
    }
}
