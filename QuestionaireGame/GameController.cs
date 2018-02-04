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
    /**
     * The game controller is defined as a singleton. This means there will only ever
     * be one instance of this class in the lifespan of the game.
     */
    class GameController
    {
        // the pools of questions that the game can choose a game setup from
        private List<MultipleAnswerQuestion> multipleAnswerQuestions;
        private List<NumberAnswerQuestion> numberAnswerQuestions;
        // TODO lägg de frågetyperna

        // The member holding the current game questions. It is from this
        // collection the controller will select the questions to present 
        // for the user.
        private List<BaseQuestion> gameSessionQuestions = new List<BaseQuestion>();
        private List<BaseQuestion> completedGameSessionQuestions = new List<BaseQuestion>();
        private BaseQuestion currentQuestion;

        // The forms that will display the question and result. We pre create these and use them
        // as a template which is automatically load with the current question.
        private FormResults frmResults;
        private FormMultipleAnswers frmMultipleAnswers;
        // TODO  add the rest of the forms here

        // The singleton member
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
            PrepareForms();
            Application.Run(frmResults);
        }

        private void PrepareForms()
        {
            frmResults = new FormResults();
            frmMultipleAnswers = new FormMultipleAnswers();
            // TODO add additional forms for the other questions.


            // make sure the dialogs are hidden since we only want to show them once
            // they contain the current question.
            frmResults.Visible = false;
            frmMultipleAnswers.Visible = false;
            // TODO make sure all dialogs are hidden
        }

        /**
         * Creates a new game instance to play. It selects questions from
         * the pool of questions according to the game rules and add them
         * to an internal member for the duration of a play session.
         */
        private void GenerateGameSessionQuestions()
        {
            // TODO get questions from the pools and add to the current game instance questions.

            // EXEMPEL: Plocka en fråga från vår pool till frågesamlingen. Här ska vi plocka
            // lite olika frågor.
            gameSessionQuestions.AddRange(multipleAnswerQuestions);
        }

        /**
         * Gets the next question to be displayed for the user.
         */
        public void ShowNextGameSessionQuestion()
        {
            if (currentQuestion != null)
            {
                completedGameSessionQuestions.Add(currentQuestion);
            }
            // Gets first question from the list and also removes it from the game session collection.
            if (gameSessionQuestions.Count<BaseQuestion>() != 0)
            {
                BaseQuestion baseQuestion = gameSessionQuestions.First<BaseQuestion>();
                gameSessionQuestions.Remove(baseQuestion);
                currentQuestion = baseQuestion;
                ShowFormFromQuestion(currentQuestion);
            }
            else
            {
                ShowResults();
            }
        }

        public void StartNewGameSession()
        {
            // Clears the previous questions.
            currentQuestion = null;
            completedGameSessionQuestions.Clear();
            gameSessionQuestions.Clear();
            // TODO Generera nya frågor
            GenerateGameSessionQuestions();

            // Visa första frågan
            ShowNextGameSessionQuestion();

        }

        private void ShowFormFromQuestion(BaseQuestion baseQuestion)
        {
            if (baseQuestion.GetType() == typeof(MultipleAnswerQuestion))
                frmMultipleAnswers.LoadQuestion((MultipleAnswerQuestion)baseQuestion);
            frmMultipleAnswers.Visible = true;
            {
            }
            if (baseQuestion.GetType() == typeof(NumberAnswerQuestion))
            {
                // TODO visa formuläret som visar nummer fråga
            }
        }

        public void InitGame()
        {
            LoadJson();
        }

        private void LoadJson()
        {
            // Load the multiple answer questions
            using (StreamReader r = new StreamReader("..\\..\\MultipleAnswerQuestions.json"))
            {
                string json = r.ReadToEnd();
                multipleAnswerQuestions = JsonConvert.DeserializeObject<List<MultipleAnswerQuestion>>(json);

                foreach (var q in multipleAnswerQuestions)
                {
                    Console.WriteLine("Question is {0}", q.Question);
                }
            }

            // load the number answer questions
            using (StreamReader r = new StreamReader("..\\..\\NumberAnswerQuestions.json"))
            {
                string json = r.ReadToEnd();
                numberAnswerQuestions = JsonConvert.DeserializeObject<List<NumberAnswerQuestion>>(json);

                foreach (var q in numberAnswerQuestions)
                {
                    Console.WriteLine("Question is {0}", q.Question);
                }
            }


            // load the text answer questions
            // TODO 

            // load the times answer questions
            // TODO 

        }

        private void ShowResults()
        {
            foreach (var q in completedGameSessionQuestions)
            {
                Console.WriteLine("Correct answer is {0}, your answer is {1}.", q.Answer, q.UserAnswer);
            }
            frmResults.setResults(completedGameSessionQuestions);
            frmResults.Visible = true;
        }


    }
}
