using System.Collections.Generic;

namespace Chess.Interfaces
{
    /// <summary>
    /// The IPiece interface, represents a piece of some kind
    /// </summary>
    public interface IPiece
    {
        /// <summary>
        /// The owner of the piece
        /// </summary>
        IPlayer Owner { get; }

        /// <summary>
        /// The piece label, used to represent the piece when drawing it
        /// </summary>
        string Label { get; }

        /// <summary>
        /// Get valid moves (destinations) for this piece for the given source position
        /// The board is needed for checking special cases like "are pieces in the way" or special moves like "pawns capturing diagonally"
        /// </summary>
        /// <param name="source">The source position</param>
        /// <param name="board">The board</param>
        /// <returns>The valid destination positions, or null if there are none</returns>
        IEnumerable<IPosition> GetValidMoves(IPosition source, IBoard board);
    }
}
