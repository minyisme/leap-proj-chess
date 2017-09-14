using Chess.Interfaces;
using System;

namespace Chess.Pieces
{
    public class Pawn : Piece
    {
        /// <summary>
        /// Constructor that expects an owner
        /// </summary>
        /// <param name="owner"></param>
        public Pawn(IPlayer owner) : base(owner)
        {
        }

        /// <summary>
        /// Is the move from source to dest valid for this piece on the specified board?
        /// </summary>
        /// <param name="source">The source position</param>
        /// <param name="dest">The dest position</param>
        /// <param name="board">The board, needed for checking things like "are pieces in the way" or special moves like "pawns capturing diagonally"</param>
        /// <returns></returns>
        public override bool IsMoveValid(Move move, Board board)
        {
            // is the move valid for this piece type?

            // pawns can only move away from their owner
            // we know what side the player is on since the owner has a property called Side
            // so based on the side, is the dest in the correct direction? If not, return false

            // pawns can only move one space, so we don't need to check if there are any pieces in between the source and the dest

            // we now know the direction is correct, so we need to check the distance
            // pawns can move in two different ways:
            // one space straight ahead if there is nothing in front of them OR
            // one space diagonally to capture an enemy piece

            // in both cases, the row changes by one, so we can check that first
            // is the dest row exactly one more or one less than the source row? If not, return false

            // checking a normal move
            // Are the source and dest column the same and is the dest empty? If yes, return true

            // checking a capture
            // Is the dest column one more/less than the source column and is the dest empty? If yes, return true

            // if we get here, we've exhausted all valid moves for pawns, so the move must be invalid
            // return false

            throw new NotImplementedException();
        }
    }
}
