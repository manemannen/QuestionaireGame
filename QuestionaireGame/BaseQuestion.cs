﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionaireGame
{
    public class BaseQuestion
    {
        protected string question;
        public string Question
        {
            get
            {
                return question;
            }
            set
            {
                question = value;
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

        public bool IsCorrect()
        {
            return answer == userAnswer;
        }

        /**
         *  Makes a shallow copy of the question.
         */
        public virtual BaseQuestion Copy()
        {
            return (BaseQuestion) this.MemberwiseClone(); 
        }
    }
}
