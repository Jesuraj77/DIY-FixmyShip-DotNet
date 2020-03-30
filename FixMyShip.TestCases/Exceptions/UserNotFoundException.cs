using System;
using System.Collections.Generic;
using System.Text;

namespace FixMyShip.TestCases.Exceptions
{
    class UserNotFoundException : Exception
    {
        public string Messages = "User Not Found";

        public UserNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
