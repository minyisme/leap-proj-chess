using Chess.Interfaces;

namespace Chess
{
    /// <summary>
    /// The position class, represents a board position
    /// </summary>
    public class Position : IPosition
    {
        /// <summary>
        /// The position row
        /// </summary>
        public int Row { get; private set; }

        /// <summary>
        /// The position column
        /// </summary>
        public int Column { get; private set; }

        /// <summary>
        /// Constructor that expects a column and row
        /// </summary>
        /// <param name="column"></param>
        /// <param name="row"></param>
        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
