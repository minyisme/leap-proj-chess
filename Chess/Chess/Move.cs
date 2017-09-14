using Chess.Interfaces;

namespace Chess
{
    /// <summary>
    /// The Move class, represents a game move
    /// </summary>
    public class Move
    {
        /// <summary>
        /// The player making the move
        /// </summary>
        public IPlayer Owner { get; set; }

        // The move source
        public Position Source { get; set; }

        // the move dest
        public Position Dest { get; set; }
    }
}
