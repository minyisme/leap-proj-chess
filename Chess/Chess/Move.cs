using Chess.Interfaces;

namespace Chess
{
    /// <summary>
    /// The Move class, represents a game move
    /// </summary>
    public class Move : IMove
    {
        // The move source
        public IPosition Source { get; set; }

        // the move dest
        public IPosition Dest { get; set; }
    }
}
