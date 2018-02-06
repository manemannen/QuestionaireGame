using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionaireGame
{
    /// <summary>
    ///  Contains one single questionaire result
    /// </summary>
    public class Result
    {
        private List<BaseQuestion> questions;
        public List<BaseQuestion> Questions { get => questions; set => questions = value; }
        private DateTime createdTime;
        public DateTime CreatedTime { get => createdTime; set => createdTime = value; }
        private String userName;
        public string UserName { get => userName; set => userName = value; }
        private long completionTime;
        public long CompletionTime { get => completionTime; set => completionTime = value; }
        public int GetCorrectAnswers()
        {
            int correctAnswers = 0;
            foreach (BaseQuestion question in questions)
            {
                if (question.IsCorrect())
                {
                    correctAnswers++;
                }
            }
            return correctAnswers;
        }
    }
}
