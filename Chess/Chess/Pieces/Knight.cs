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
        public Knight(IPlayer owner) : base(owner, "N")
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
            List<IPosition> allMoves = new List<IPosition>();
            List<IPosition> validMoves = new List<IPosition>();

            // Generate all the destination positions for this piece based on the source 
            // and the piece move rules

            allMoves.Add(new Position(source.Row + 2, source.Column + 1));
            allMoves.Add(new Position(source.Row + 2, source.Column - 1));
            allMoves.Add(new Position(source.Row + 1, source.Column + 2));
            allMoves.Add(new Position(source.Row - 1, source.Column + 2));
            allMoves.Add(new Position(source.Row - 2, source.Column + 1));
            allMoves.Add(new Position(source.Row - 2, source.Column - 1));
            allMoves.Add(new Position(source.Row + 1, source.Column - 2));
            allMoves.Add(new Position(source.Row - 1, source.Column - 2));
            
            // if there are pieces between the source and any of the destinations (ask the board),
            // that destination is invalid since pieces can't move through other pieces 
            // This check doesn't have to be done for Knights, but does have to be done
            // for every other piece

            // Checks for other pieces on possible positions, and checks if opponent piece or not
            // TODO: Need add check for board borders, cannot move outside of board!!!
            for (var i = 0; i < allMoves.Count; i++)
            {
                var currentPosition = allMoves[i];
                var piece = board.GetPiece(currentPosition);

                if ((piece != null && this.Owner != piece.Owner) || piece == null)
                {
                    validMoves.Add(currentPosition);
                }
            }

            return validMoves;
        }
    }
}
