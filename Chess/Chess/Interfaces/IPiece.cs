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
        /// Is the move valid for this piece, given the current board state?
        /// The board is needed for checking special cases like "are pieces in the way" or special moves like "pawns capturing diagonally"
        /// </summary>
        /// <param name="move">The move</param>
        /// <param name="board">The board</param>
        /// <returns></returns>
        bool IsMoveValid(Move move, Board board);
    }
}
