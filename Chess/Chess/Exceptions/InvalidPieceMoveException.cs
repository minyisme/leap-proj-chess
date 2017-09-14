using System;

namespace Chess.Exceptions
{
    /// <summary>
    /// Exception representing an invalid input from the user
    /// </summary>
    public class InvalidPieceMoveException : Exception
    {
        public InvalidPieceMoveException()
        {
        }

        public InvalidPieceMoveException(string message)
        : base(message)
        {
        }

        public InvalidPieceMoveException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
