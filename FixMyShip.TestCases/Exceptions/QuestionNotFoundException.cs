using System;
using System.Collections.Generic;
using System.Text;

namespace FixMyShip.TestCases.Exceptions
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
