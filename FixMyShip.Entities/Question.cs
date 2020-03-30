using System;
using System.Collections.Generic;
using System.Text;

namespace FixMyShip.Entities
{
    public class Question
    {
        public virtual int QuestionId { get; set; }
        public virtual string QuestionDetails { get; set; }
    }
}
