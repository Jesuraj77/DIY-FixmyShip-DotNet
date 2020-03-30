using System;
using System.Collections.Generic;
using System.Text;

namespace FixMyShip.Test.Exeptions
{
    class QuestionNotFoundException : Exception
    {
        public string Messages = "Question Not Found";

        public QuestionNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
