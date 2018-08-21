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

        private bool isKingRemoved { get; set; } = false;

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
            this.NumRows = 8;
            this.NumColumns = 8;
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
            var validMoves = this.pieces[move.Source.Row, move.Source.Column].GetValidMoves(move.Source, this);
            // If the specified destination is not in the valid move list,
            // throw an InvalidPieceMoveException with an appropriate message
            var validMove = false;
            foreach (var moveOption in validMoves)
            {
                if (move.Dest == moveOption)
                {
                    validMove = true;
                }
            }
            if (validMove == false)
            {
                throw new Exception("Invalid Board Move");
            }
            // once we get here, we know the move is valid
            // move the piece, overwriting the enemy piece in dest if there is one
            if (pieces[move.Dest.Row, move.Dest.Column].Label == "K")
            {
                isKingRemoved = true;
            }
            this.pieces[move.Dest.Row, move.Dest.Column] = this.pieces[move.Source.Row, move.Source.Column];
            this.pieces[move.Source.Row, move.Source.Column] = null;
        }

        /// <summary>
        /// Is the specified column valid?
        /// </summary>
        /// <param name="column">The column number</param>
        /// <returns>True if yes, false otherwise</returns>
        public bool IsColumnValid(int column)
        {
            // write code to check if the specified column is "on the board"
            if (column > 0 && column <= NumColumns)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Is the specified row valid?
        /// </summary>
        /// <param name="row">The row number</param>
        /// <returns>True if yes, false otherwise</returns>
        public bool IsRowValid(int row)
        {
            if (row > 0 && row <= NumRows)
            {
                return true;
            }
            return false;
            // write code to check if the specified column is "on the board"
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
            if (p1 == null || p2 == null)
            {
                throw new ArgumentNullException();
            }
            // if p1 and p2 are the same, return false
            if (p1 == p2)
            {
                return false;
            }
            // if p1 and p2 don't share a row, column, or a diagonal, return false
            if (p1.Row != p2.Row && p1.Column != p2.Column && p1.Row - p2.Row != p1.Column - p2.Column && p1.Row - p2.Row != -(p1.Column - p2.Column)) // To do: check diagonal
            {
                return false;
            }
            // if they are in the same row, check the columns between them in the same row
            // if there are any pieces there, return true. Otherwise, return false

            if (p1.Row == p2.Row)
            {
                if (p2.Column > p1.Column)
                {
                    for (var i = p1.Column + 1; i < p2.Column; i++)
                    {
                        if (pieces[p1.Row, i] != null)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    for (var i = p2.Column + 1; i < p1.Column; i++)
                    {
                        if (pieces[p1.Row, i] != null)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }

            // if they are in the same column, check the rows between them in the same column
            // if there are any pieces there, return true. Otherwise, return false

            if (p1.Column == p2.Column)
            {
                if (p2.Row > p1.Row)
                {
                    for (var i = p1.Row + 1; i < p2.Row; i++)
                    {
                        if (pieces[p1.Column, i] != null)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    for (var i = p2.Row + 1; i < p1.Row; i++)
                    {
                        if (pieces[p1.Column, i] != null)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }

            // if they share a diagonal, check the squares between them on the shared diagonal
            // if there are any pieces there, return true. Otherwise, return false

            if (p2.Row > p1.Row && p2.Column > p1.Column)
            {
                for (var i = 1; i + p1.Row < p2.Row; i++)
                {
                    if (pieces[p1.Row + i, p1.Column + i] != null)
                    {
                        return true;
                    }
                }
            }
            else if (p2.Row < p1.Row && p2.Column < p1.Column)
            {
                for (var i = 1; i + p2.Row < p1.Row; i++)
                {
                    if (pieces[p2.Row + i, p2.Column + i] != null)
                    {
                        return true;
                    }
                }
            }
            else if (p2.Row > p1.Row && p2.Column < p1.Column)
            {
                for (var i = 1; i + p1.Row < p2.Row; i++)
                {
                    if (pieces[p1.Row + i, p1.Column - i] != null)
                    {
                        return true;
                    }
                }
            }
            else
            {
                for (var i = 1; i + p2.Row < p1.Row; i++)
                {
                    if (pieces[p1.Row - i, p1.Column + i] != null)
                    {
                        return true;
                    }
                }
            }
            return false;
            
        }
    }
}
