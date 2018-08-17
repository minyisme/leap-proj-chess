using Chess.Interfaces;
using System;
using System.Collections.Generic;

namespace Chess.Pieces
{
    /// <summary>
    /// Abstract Piece class, represents a piece of some type
    /// I made this to store the common functionality of all pieces
    /// You should inherit from this class to create your specific chess pieces
    /// </summary>
    public abstract class Piece : IPiece
    {
        public IPlayer Owner { get; private set; }
        public string Label { get; private set; }

        /// <summary>
        /// Constructor that expects an owner, since all pieces must have an owner
        /// </summary>
        /// <param name="owner">The player that owns the piece</param>
        /// <param name="label">The label for the piece, controls how to draw it</param>
        public Piece(IPlayer owner, string label)
        {
            // validate the inputs
            if (owner == null)
            {
                throw new ArgumentNullException();
            }
            
            if (String.IsNullOrEmpty(label))
            {
                throw new ArgumentNullException();
            }

            Owner = owner;
            Label = label;
        }

        /// <summary>
        /// Get valid moves (destinations) for this piece for the given source position
        /// The board is needed for checking special cases like "are pieces in the way" or special moves like "pawns capturing diagonally"
        /// This is abstract and meant to be overridden by concrete piece classes
        /// </summary>
        /// <param name="move">The move</param>
        /// <param name="board">The board</param>
        /// <returns>The valid destination positions, or null if there are none</returns>
        public abstract IEnumerable<IPosition> GetValidMoves(IPosition source, IBoard board);

        /// <summary>
        /// Override of ToString, used to draw the piece when drawing the board
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Label;
        }
    }
}
