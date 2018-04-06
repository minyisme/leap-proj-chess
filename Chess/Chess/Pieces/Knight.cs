using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Interfaces;

namespace Chess.Pieces
{
    /// <summary>
    /// The knight piece
    /// </summary>
    public class Knight : Piece
    {
        /// <summary>
        /// Constructor that expects an owner
        /// </summary>
        /// <param name="owner"></param>
        public Knight(IPlayer owner) : base(owner, "k")
        {
        }

        /// <summary>
        /// Get valid moves (destinations) for this piece for the given source position
        /// The board is needed for checking special cases like "are pieces in the way" or special moves like "pawns capturing diagonally"
        /// This is abstract and meant to be overridden by concrete piece classes
        /// </summary>
        /// <param name="move">The move</param>
        /// <param name="board">The board</param>
        /// <returns>The valid destination positions, or null if there are none</returns>
        public override IEnumerable<IPosition> GetValidMoves(IPosition source, IBoard board)
        {
            // knights can move in any direction and can jump over pieces
            // They must move in an "L" pattern (2 in one direction, 1 in the other)

            // Generate all the destination positions for this piece based on the source 
            // and the piece move rules

            // if there are pieces between the source and any of the destinations (ask the board),
            // that destination is invalid since pieces can't move through other pieces 
            // This check doesn't have to be done for Knights, but does have to be done
            // for every other piece

            // return the valid destinations for the current piece
            throw new NotImplementedException();
        }
    }
}
