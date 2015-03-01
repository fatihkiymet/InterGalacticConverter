using System;

namespace UnitConverter
{
    public class InvalidSubtractionException : Exception
    {
        public InvalidSubtractionException(string message)
            : base(message)
        {
            
        }
    }
}
