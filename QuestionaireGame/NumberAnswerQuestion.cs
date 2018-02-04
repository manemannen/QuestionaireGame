using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionaireGame
{
    public class NumberAnswerQuestion : BaseQuestion
    {

        protected string answer;
        public string Answer
        {
            get
            {
                return answer;

            }
            set
            {
                answer = value;
            }
        }

        protected string userAnswer;
        public string UserAnswer
        {
            get
            {
                return userAnswer;

            }
            set
            {
                userAnswer = value;
            }
        }

    }
}
