namespace Chess.Interfaces
{
    /// <summary>
    /// The IPlayerInterface, represents a game player
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// The player's name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The side of the board the player is sitting on
        /// </summary>
        BoardSide Side { get; }

        /// <summary>
        /// The player's color
        /// </summary>
        PlayerColor Color { get; }

        /// <summary>
        /// Get a move from the player
        /// </summary>
        /// <returns>The move</returns>
        IMove GetMove();
    }
}
