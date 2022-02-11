using System;
using System.Collections.Generic;
using System.Text;

namespace KataStringCalculator
{
    public class SeparatorAtTheEndOfStringException : Exception
    {
        public SeparatorAtTheEndOfStringException()
        {
        }

        public SeparatorAtTheEndOfStringException(string message) : base(message)
        {
        }

        public SeparatorAtTheEndOfStringException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
