using Chess.Interfaces;
using System;

namespace Chess
{
    /// <summary>
    /// The HumanPlayer class, represents a human player
    /// </summary>
    public class HumanPlayer : IPlayer
    {
        /// <summary>
        /// The player's name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The side of the board the player is on, used to validate moves
        /// </summary>
        public BoardSide Side { get; private set; }

        /// <summary>
        /// The player's color, used to color their pieces when drawing
        /// </summary>
        public PlayerColor Color { get; private set; }

        /// <summary>
        /// The move provider, used for getting moves
        /// </summary>
        private IMoveProvider mp;

        /// <summary>
        /// Constructor that uses the default move provider which reads from the console
        /// </summary>
        /// <param name="name">The player name</param>
        /// <param name="side">The side of the board the player sits on</param>
        public HumanPlayer(string name, BoardSide side, PlayerColor color) : this(name, side, color, new MoveProvider())
        {

        }

        /// <summary>
        /// Constructor that uses a specific IMoveProvider, used for unit testing
        /// </summary>
        /// <param name="name">The name of the player</param>
        /// <param name="side">The side of the board the player sits on</param>
        /// <param name="color">The color of the player's pieces</param>
        /// <param name="mp">The move provider</param>
        public HumanPlayer(string name, BoardSide side, PlayerColor color, IMoveProvider mp)
        {
            // validate the inputs
            // If name is null or empty, throw an ArgumentNullException
            // If mp is null, throw an ArgumentNullException
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Please provide a valid name");
            }

            Name = name;
            Side = side;
            Color = color;
            this.mp = mp ?? throw new ArgumentNullException("Please provide a move Provider");
        }

        /// <summary>
        /// Get a move
        /// </summary>
        /// <returns>The move</returns>
        public IMove GetMove()
        {
            var currentMove = mp.GetMove();
            return currentMove;
            // get the move from the move provider
            // set the move owner to the current player (using "this") since this is used during validation
        }
    }
}
