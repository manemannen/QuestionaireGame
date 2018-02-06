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
        // The previous results
        private List<Result> results;
        // the pools of questions that the game can choose a game session from
        private List<MultipleAnswerQuestion> multipleAnswerQuestions;
        private List<NumberAnswerQuestion> numberAnswerQuestions;
        private List<TextAnswerQuestion> textAnswerQuestions;
        private List<TimedNumberAnswerQuestion> timedNumberAnswerQuestions;

        // The member holding the current game questions. It is from this
        // collection the controller will select the questions to present 
        // for the user.
        private List<BaseQuestion> gameSessionQuestions = new List<BaseQuestion>();
        private List<BaseQuestion> completedGameSessionQuestions = new List<BaseQuestion>();
        private BaseQuestion currentQuestion;
        private long currentPlaySessionStartTime;

        // The forms that will display the question and result. We pre create these and use them
        // as a template which is automatically load with the current question.
        private FormResults frmResults;
        private FormMultipleAnswers frmMultipleAnswers;
        private FormNumberAnswer frmNumberAnswers;
        private FormTextAnswer frmTextAnswers;
        private FormTimedNumberAnswer frmTimedNumberAnswers;

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
            frmNumberAnswers = new FormNumberAnswer();
            frmTextAnswers = new FormTextAnswer();
            frmTimedNumberAnswers = new FormTimedNumberAnswer();
            // make sure the dialogs are hidden since we only want to show them once
            // they contain the current question.
            frmResults.Visible = false;
            frmMultipleAnswers.Visible = false;
            frmNumberAnswers.Visible = false;
            frmTextAnswers.Visible = false;
            frmTimedNumberAnswers.Visible = false;

            frmResults.SetResults(results);

        }

        /**
         * Creates a new game instance to play. It selects questions from
         * the pool of questions according to the game rules and add them
         * to an internal member for the duration of a play session.
         */
        private void GenerateGameSessionQuestions()
        {
            //gameSessionQuestions.AddRange(GetRandomQuestions(3, multipleAnswerQuestions));
            //gameSessionQuestions.AddRange(GetRandomQuestions(3, numberAnswerQuestions));
            //gameSessionQuestions.AddRange(GetRandomQuestions(3, textAnswerQuestions));
            gameSessionQuestions.AddRange(GetRandomQuestions(1, timedNumberAnswerQuestions));
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
                BaseQuestion baseQuestion = GetRandomQuestions(1, gameSessionQuestions).First<BaseQuestion>();                    
                gameSessionQuestions.Remove(baseQuestion);
                currentQuestion = baseQuestion;
                ShowFormFromQuestion(currentQuestion);
            }
            else
            {
                long totalTimeSpent = TimeSpan.FromTicks(DateTime.UtcNow.Ticks).Seconds - TimeSpan.FromTicks(currentPlaySessionStartTime).Seconds;

                string input = "John Doe";
                // get the user name
                ShowInputDialog(ref input);

                Result result = new Result();
                result.CreatedTime = DateTime.Now;
                result.Questions = new List<BaseQuestion>(completedGameSessionQuestions);
                result.UserName = input;
                result.CompletionTime = totalTimeSpent;
                results.Add(result);
                SaveResultsToJson();
                ShowResults();
            }
        }

        public void StartNewGameSession()
        {
            // Clears the previous questions.
            currentQuestion = null;
            completedGameSessionQuestions.Clear();
            gameSessionQuestions.Clear();
            // Generate a new game session
            GenerateGameSessionQuestions();
            currentPlaySessionStartTime = DateTime.UtcNow.Ticks;
            // Show the first question
            ShowNextGameSessionQuestion();
        }

        /**
         * Show correct form depending on what type of question it is.
         */
        private void ShowFormFromQuestion(BaseQuestion baseQuestion)
        {
            if (baseQuestion.GetType() == typeof(MultipleAnswerQuestion))
            {
                frmMultipleAnswers.LoadQuestion((MultipleAnswerQuestion)baseQuestion);
                frmMultipleAnswers.Visible = true;
            }
            else if (baseQuestion.GetType() == typeof(NumberAnswerQuestion))
            {
                frmNumberAnswers.LoadQuestion((NumberAnswerQuestion)baseQuestion);
                frmNumberAnswers.Visible = true;
            }
            else if (baseQuestion.GetType() == typeof(TextAnswerQuestion))
            {
                frmTextAnswers.LoadQuestion((TextAnswerQuestion)baseQuestion);
                frmTextAnswers.Visible = true;
            }
            else if (baseQuestion.GetType() == typeof(TimedNumberAnswerQuestion))
            {
                frmTimedNumberAnswers.LoadQuestion((TimedNumberAnswerQuestion)baseQuestion);
                frmTimedNumberAnswers.Visible = true;
            }

        }

        public void InitGame()
        {
            LoadResultsFromJson();
            LoadQuestionsFromJson();
        }

        /**
         * Loads all the result from an external file.
         */
        private void LoadResultsFromJson()
        {
            try
           {
                using (StreamReader r = new StreamReader("Results.json"))
                {
                    string json = r.ReadToEnd();
                    results = JsonConvert.DeserializeObject<List<Result>>(json);
                }            
            }
            catch (FileNotFoundException)
            {
                // the file does not exist so we create an empty collection
                results = new List<Result>();
            }
        }

        /**
         * Saves all the result to an external file.
         */
        private void SaveResultsToJson()
        {
            //new StreamWriter("Results.json", true))
            using (StreamWriter w = File.CreateText("Results.json"))
            {
                string json = JsonConvert.SerializeObject(results);
                w.WriteLine(json);
            }
        }

        /**
         * Loads the question from external json files.
         */
        private void LoadQuestionsFromJson()
        {
            // Load the multiple answer questions
            using (StreamReader r = new StreamReader("..\\..\\MultipleAnswerQuestions.json"))
            {
                string json = r.ReadToEnd();
                multipleAnswerQuestions = JsonConvert.DeserializeObject<List<MultipleAnswerQuestion>>(json);
            }

            // load the number answer questions
            using (StreamReader r = new StreamReader("..\\..\\NumberAnswerQuestions.json"))
            {
                string json = r.ReadToEnd();
                numberAnswerQuestions = JsonConvert.DeserializeObject<List<NumberAnswerQuestion>>(json);
            }

            // load the text answer questions
            using (StreamReader r = new StreamReader("..\\..\\TextAnswerQuestions.json"))
            {
                string json = r.ReadToEnd();
                textAnswerQuestions = JsonConvert.DeserializeObject<List<TextAnswerQuestion>>(json);
            }


            // load the times answer questions
            using (StreamReader r = new StreamReader("..\\..\\TimedNumberAnswerQuestions.json"))
            {
                string json = r.ReadToEnd();
                timedNumberAnswerQuestions = JsonConvert.DeserializeObject<List<TimedNumberAnswerQuestion>>(json);
            }

        }

        /**
         * Sets the answer questions in the result form to be displayed. 
         */
        private void ShowResults()
        {
            frmResults.SetResults(results);
            frmResults.Visible = true;
        }


        private IEnumerable<BaseQuestion> GetRandomQuestions(int questionCount, IEnumerable<BaseQuestion> questions)
        {
            if (questionCount > questions.Count<BaseQuestion>())
            {
                throw new Exception("Not enough questions");
            }
            List<BaseQuestion> list = new List<BaseQuestion>();
            while (list.Count < questionCount)
            {
                Random random = new Random();
                int index = random.Next(0, questions.Count<BaseQuestion>()- 1);
                BaseQuestion question = questions.ElementAt<BaseQuestion>(index);
                if (!list.Contains<BaseQuestion>(question))
                {
                    list.Add(question);
                }
            }
            // we need to copy the questions to not taint the same objects in several consequent games
            List<BaseQuestion> copies = new List<BaseQuestion>();
            foreach(BaseQuestion q in copies){
                copies.Add(q.Copy());
            }
            return list;
        }

        // copied from StackOverflow :)
        private DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Ditt namn";

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            inputBox.Left = frmResults.Left;
            inputBox.Top = frmResults.Top;
            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }
    }
}
