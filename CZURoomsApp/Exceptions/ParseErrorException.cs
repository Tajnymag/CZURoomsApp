using System;

namespace CZURoomsApp.Exceptions
{
    /// <summary>
    /// Výjimka informující o jakékoli chybě při parsování dat
    /// </summary>
    public class ParseErrorException : Exception
    {
        public ParseErrorException()
        {
        }

        public ParseErrorException(string message) : base(message)
        {
        }

        public ParseErrorException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}