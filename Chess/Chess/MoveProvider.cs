using Chess.Interfaces;
using System;
using Chess.Exceptions;

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
            if (ip == null)
            {
                throw new ArgumentNullException();
            }

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
            Console.WriteLine("Choose a piece to move and give the x coordinate.");
            string _sSourceX = ip.Read();
            Console.WriteLine("Choose a piece to move and give the y coordinate.");
            string _sSourceY = ip.Read();
            Console.WriteLine("Choose an x coordinate to move to.");
            string _sDestX = ip.Read();
            Console.WriteLine("Choose a y coordinate to move to.");
            string _sDestY = ip.Read();

            try
            {
                int sourceX = Convert.ToInt32(_sSourceX);
                int sourceY = Convert.ToInt32(_sSourceY);

                int destX = Convert.ToInt32(_sDestX);
                int destY = Convert.ToInt32(_sDestY);

                var move = new Move
                {
                    Source = new Position(sourceY, sourceX),
                    Dest = new Position(destY, destX)
                };
                return move;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine($"{e.Message}: invalid input.");
                throw new InvalidInputException();
            }
        }
    }
}
