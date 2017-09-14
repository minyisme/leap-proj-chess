using System;

namespace Chess.Exceptions
{
    /// <summary>
    /// Exception representing an invalid input from the user
    /// </summary>
    public class InvalidBoardMoveException : Exception
    {
        public InvalidBoardMoveException()
        {
        }

        public InvalidBoardMoveException(string message)
        : base(message)
        {
        }

        public InvalidBoardMoveException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
