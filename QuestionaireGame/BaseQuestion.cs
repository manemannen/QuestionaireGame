using System;
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
    }
}
