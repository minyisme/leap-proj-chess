using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Interfaces
{
    /// <summary>
    /// The Board interface, represents a board abstraction
    /// </summary>
    public interface IBoard
    {
        /// <summary>
        /// The number of rows on the board
        /// </summary>
        int NumRows { get; }

        /// <summary>
        /// The number of columns on the board
        /// </summary>
        int NumColumns { get; }

        /// <summary>
        /// Get the piece at the specified location
        /// </summary>
        /// <param name="position">The position</param>
        /// <returns>The piece, or null if there is none</returns>
        IPiece GetPiece(IPosition position);

        /// <summary>
        /// Add a piece to the board, used for board initialization
        /// </summary>
        /// <param name="piece">The piece to be placed</param>
        /// <param name="position">The position</param>
        void AddPiece(IPiece piece, IPosition position);

        /// <summary>
        /// Move a piece on the board
        /// </summary>
        /// <param name="player">The player making the move</param>
        /// <param name="move">The move</param>
        void MovePiece(IPlayer player, IMove move);

        /// <summary>
        /// Check if pieces are between the two specified positions (excluding the positions)
        /// </summary>
        /// <param name="source">The source position</param>
        /// <param name="dest">The dest position</param>
        bool ArePiecesBetween(IPosition source, IPosition dest);

        /// <summary>
        /// Draw the board
        /// </summary>
        void Draw(IBoardRenderer renderer);
    }
}
