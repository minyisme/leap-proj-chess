using Chess.Interfaces;
using System;

namespace Chess
{
    /// <summary>
    /// The MoveProvider class, gets moves from somewhere
    /// </summary>
    public class MoveProvider : IMoveProvider
    {
        /// <summary>
        /// The input provider that this will use to get inputs
        /// </summary>
        private IInputProvider ip;

        /// <summary>
        /// Default constructor, uses the console to get all inputs
        /// </summary>
        public MoveProvider() : this(new ConsoleInputProvider())
        {

        }

        /// <summary>
        /// Constructor with a specified input provider, used for unit tests
        /// </summary>
        /// <param name="ip"></param>
        public MoveProvider(IInputProvider ip)
        {
            // validate the inputs
            // If ip is null, throw an ArgumentNullException

            this.ip = ip;
        }

        /// <summary>
        /// Get a move
        /// </summary>
        /// <returns>The move</returns>
        public IMove GetMove()
        {
            // This function should get input from the input provider
            // and create a move from it, returning that move

            // if the input is invalid (can't be parsed into an int, for example), 
            // you should throw an InvalidInputException
            throw new NotImplementedException();
        }
    }
}
