using System;

namespace NumberConverter
{
    public class ParseException : Exception
    {
        public ParseException(string message) : base (message)
        {
            
        }
    }
}
