using System;

namespace NumberConverter
{
    public class InvalidSubtractionException : Exception
    {
        public InvalidSubtractionException(string message)
            : base(message)
        {
            
        }
    }
}
