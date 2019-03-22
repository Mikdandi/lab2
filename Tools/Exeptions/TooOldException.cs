using System;


namespace lab2.Tools.Exeptions
{
    class TooOldException : Exception
    {
        public TooOldException()
        {
        }

        public TooOldException(string message) : base(message)
        {
        }

        public TooOldException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
