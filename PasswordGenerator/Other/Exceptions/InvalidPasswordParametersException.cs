using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator.Other.Exceptions
{
    public class InvalidPasswordParametersException : Exception
    {
        public InvalidPasswordParametersException(string message) : base(message)
        {
        }
    }
}
