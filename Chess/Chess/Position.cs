namespace Chess
{
    /// <summary>
    /// The position class, represents a board position
    /// </summary>
    public class Position
    {
        /// <summary>
        /// The X part of the position
        /// </summary>
        public int Row { get; private set; }

        /// <summary>
        /// The Y part of the position
        /// </summary>
        public int Column { get; private set; }

        /// <summary>
        /// Constructor that expects a column and row
        /// </summary>
        /// <param name="column"></param>
        /// <param name="row"></param>
        public Position(int column, int row)
        {
            Column = column;
            Row = row;
        }
    }
}
