using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionaireGame
{
  public class TimedNumberAnswerQuestion : BaseQuestion
    {
        private int completionTime;
        public int CompletionTime { get => completionTime; set => completionTime = value; }
        public override BaseQuestion Copy()
        {
            return (BaseQuestion)this.MemberwiseClone();
        }
    }
}
