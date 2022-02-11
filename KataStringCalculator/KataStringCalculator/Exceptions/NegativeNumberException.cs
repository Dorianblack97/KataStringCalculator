using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace KataStringCalculator.Exceptions
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException()
        {
        }

        public NegativeNumberException(string message) : base("Negative number(s) not allowed")
        {
        }

        public NegativeNumberException(string message, Exception innerException) : base("Negative number(s) not allowed", innerException)
        {
        }

    }
}
