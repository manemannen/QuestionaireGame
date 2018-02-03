using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionaireGame
{
    public class MultipleAnswerQuestion : BaseQuestion
    {
        protected string answerOption1;
        public string AnswerOption1
        {
            get
            {
                return answerOption1;
            }
            set
            {
                answerOption1 = value;
            }
        }

        protected string answerOption2;
        public string AnswerOption2
        {
            get
            {
                return answerOption2;
            }
            set
            {
                answerOption2 = value;
            }
        }
        
        protected string answerOption3;
        public string AnswerOption3
        {
            get
            {
                return answerOption3;
            }
            set
            {
                answerOption3 = value;
            }
        }

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
