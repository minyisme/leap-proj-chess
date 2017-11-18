using Chess.Interfaces;
using System;

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
            // If owner is null, throw an ArgumentNullException
            // If label is null or empty, throw an appropriate exception

            Owner = owner;
            Label = label;
        }

        /// <summary>
        /// Is the move valid for this piece, given the current board state?
        /// The board is needed for checking special cases like "are pieces in the way" or special moves like "pawns capturing diagonally"
        /// This method is virtual and is meant to be overridden in derived pieces
        /// </summary>
        /// <param name="move">The move</param>
        /// <param name="board">The board</param>
        /// <returns></returns>
        public virtual bool IsMoveValid(Move move, Board board)
        {
            throw new NotImplementedException();
        }

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
