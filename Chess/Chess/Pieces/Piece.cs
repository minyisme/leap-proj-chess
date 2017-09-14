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
        public IPlayer Owner { get; set; }
        public string Label { get; set; }

        /// <summary>
        /// Constructor that expects an owner, since all pieces must have an owner
        /// </summary>
        /// <param name="owner">The player that owns the piece</param>
        public Piece(IPlayer owner)
        {
            // validate the inputs
            // If owner is null, throw an ArgumentNullException

            Owner = owner;
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
        /// Uses the label, or the first letter of the owner's name if the label is not set
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // if the label is null, use the first letter of the owner's name
            // otherwise, use the label
            throw new NotImplementedException();
        }
    }
}
