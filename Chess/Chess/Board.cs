using Chess.Interfaces;
using System;

namespace Chess
{
    /// <summary>
    /// The board class, represents the game board
    /// </summary>
    public class Board : IBoard
    {
        // the rows and columns, hardcoded
        private const int rows = 8;
        private const int columns = 8;

        // need a data structure of IPieces to represent pieces on the board
        // the board, represented by a 2d array of pieces
        private IPiece[,] pieces;

        /// <summary>
        /// The number of rows on the board
        /// </summary>
        public int NumRows { get; protected set; }

        /// <summary>
        /// The number of columns on the board
        /// </summary>
        public int NumColumns { get; protected set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Board() : this(rows, columns)
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="numRows">The number of rows</param>
        /// <param name="numRows">The number columns</param>
        public Board(int numRows, int numColumns)
        {
            // validate the inputs

            NumRows = numRows;
            NumColumns = numColumns;
            pieces = new IPiece[NumRows, NumColumns];
        }

        /// <summary>
        /// Constuctor used for unit testing
        /// </summary>
        /// <param name="pieces">The pieces</param>
        public Board(IPiece[,] pieces)
        {
            // validate the inputs

            this.pieces = pieces;

            // calculate the number of rows and columns and update num rows and num columns
        }

        /// <summary>
        /// Get the piece at the specified position
        /// </summary>
        /// <param name="column">The column</param>
        /// <param name="row">The row</param>
        /// <returns>The piece, or null if there is none</returns>
        public IPiece GetPiece(IPosition p)
        {
            // validate the inputs!
            if (p == null)
            {
                throw new ArgumentNullException();
            }
            return this.pieces[p.Row, p.Column];
            // get the piece at the specified position
            // if there is no piece, return null
        }

        /// <summary>
        /// Add a piece to the board, used for board initialization
        /// </summary>
        /// <param name="piece">The piece to be placed</param>
        /// <param name="position">The position</param>
        public void AddPiece(IPiece piece, IPosition p)
        {
            // validate the inputs!
            if (piece == null || p == null)
            {
                throw new ArgumentNullException();
            }
            // Add the specified piece to the board at the specified position
            this.pieces[p.Row, p.Column] = piece;
        }

        /// <summary>
        /// Move a piece on the board
        /// </summary>
        public void MovePiece(IPlayer player, IMove move)
        {
            // validate the inputs!
            if (player == null || move == null)
            {
                throw new ArgumentNullException();
            }
            // if there is no piece at the source, throw an InvalidBoardMoveException 
            // with an appropriate message
            if (this.pieces[move.Dest.Row, move.Dest.Column] == null)
            {
                throw new Exception("Invalid board move");
            }
            // if there is a piece in the source, but the specified player is not the piece owner, 
            // throw an InvalidBoardMoveException with an appropriate message
            if (this.pieces[move.Dest.Row, move.Dest.Column].Owner != player)
            {
                throw new Exception("Invalid board move");
            }
            // if there is a piece in the dest, but the piece owner and the move owner are the same, 
            // throw an InvalidBoardMoveException with an appropriate message
            if (this.pieces[move.Dest.Row, move.Dest.Column].Owner == player)
            {
                throw new Exception("Invalid board move");
            }
            // Ask the piece for valid moves based on the piece position
            // This works because GetValidMoves is absrtact and will be called on the correct concrete piece
            if (this.pieces[move.Source.Row, move.Source.Column].GetValidMoves())
            // If the specified destination is not in the valid move list,
            // throw an InvalidPieceMoveException with an appropriate message

            // once we get here, we know the move is valid
            // move the piece, overwriting the enemy piece in dest if there is one
        }

        /// <summary>
        /// Is the specified column valid?
        /// </summary>
        /// <param name="column">The column number</param>
        /// <returns>True if yes, false otherwise</returns>
        public bool IsColumnValid(int column)
        {
            // write code to check if the specified column is "on the board"
            throw new NotImplementedException();
        }

        /// <summary>
        /// Is the specified row valid?
        /// </summary>
        /// <param name="row">The row number</param>
        /// <returns>True if yes, false otherwise</returns>
        public bool IsRowValid(int row)
        {
            // write code to check if the specified column is "on the board"
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draw the board using a specified renderer
        /// </summary>
        /// <param name="renderer">The board renderer</param>
        public void Draw(IBoardRenderer renderer)
        {
            renderer.Render(this);
        }

        /// <summary>
        /// Check if pieces are between the two specified positions (excluding the positions)
        /// </summary>
        /// <param name="source">The source position</param>
        /// <param name="dest">The dest position</param>
        /// <returns>True if there are pieces between, false otherwise</returns>
        public bool ArePiecesBetween(IPosition p1, IPosition p2)
        {
            // validate the inputs!

            // if p1 and p2 are the same, return false
            // if p1 and p2 don't share a row, column, or a diagonal, return false

            // if they are in the same row, check the columns between them in the same row
            // if there are any pieces there, return true. Otherwise, return false

            // if they are in the same column, check the rows between them in the same column
            // if there are any pieces there, return true. Otherwise, return false

            // if they share a diagonal, check the squares between them on the shared diagonal
            // if there are any pieces there, return true. Otherwise, return false
            throw new NotImplementedException();
        }
    }
}
