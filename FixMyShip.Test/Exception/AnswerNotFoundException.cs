using System;
using System.Collections.Generic;
using System.Text;

namespace FixMyShip.Test.Exeptions
{

    public class AnswerNotFoundException : Exception
    {
        public string Messages = "Answer Not Found";

        public AnswerNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
