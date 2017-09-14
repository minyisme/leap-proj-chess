using Chess.Interfaces;
using System;

namespace Chess
{
    /// <summary>
    /// The board class, represents the game board
    /// </summary>
    public class Board
    {
        // need a data structure of IPieces to represent pieces on the board
        // (a 2D array or an array of arrays would probably be appropriate)
        // empty spots will just contain null

        /// <summary>
        /// The output provider, used to draw the board
        /// </summary>
        private IOutputProvider outputProvider;

        /// <summary>
        /// Default constructor, uses the Console for all outputs
        /// </summary>
        public Board() : this(new ConsoleOutputProvider())
        {

        }

        /// <summary>
        /// Constructor with a specified IOutputProvider, used for unit testing
        /// </summary>
        /// <param name="outputProvider">The output provider</param>
        public Board(IOutputProvider outputProvider)
        {
            // validate the inputs!

            this.outputProvider = outputProvider;
        }

        /// <summary>
        /// Get the piece at the specified position
        /// </summary>
        /// <param name="column">The column</param>
        /// <param name="row">The row</param>
        /// <returns>The piece, or null if there is none</returns>
        public IPiece GetPiece(Position p)
        {
            // validate the inputs!

            // get the piece at the specified position
            // if there is no piece, return null
            throw new NotImplementedException();
        }

        /// <summary>
        /// Add a piece to the board, used for initializing the board
        /// Use MovePiece to move existing pieces
        /// </summary>
        /// <param name="piece">The piece to be added</param>
        /// <param name="position">The position</param>
        public void AddPiece(IPiece piece, Position p)
        {
            // validate the inputs!

            // Add the specified piece to the board at the specified position
            throw new NotImplementedException();
        }

        /// <summary>
        /// Move a piece
        /// </summary>
        /// <param name="move">The move</param>
        public void MovePiece(Move move)
        {
            // validate the inputs!

            // if there is no piece at the source, throw an InvalidBoardMoveException with an appropriate message
            // if there is a piece in the source, but the piece owner and move owner are different, throw an InvalidBoardMoveException with an appropriate message
            // if there is a piece in the dest, but the piece owner and the move owner are the same, throw an InvalidBoardMoveException with an appropriate message

            // Ask the piece if the move is valid for that piece type
            // Note that because IsMoveValid is virtual, it is polymorphic by nature, and it will be called on the correct derived class of piece
            // if it's not, throw an InvalidPieceMoveException with an appropriate message

            // once we get here, we know the move is valid
            // move the piece, overwriting the enemy piece in dest if there is one
        }

        /// <summary>
        /// Draw the board
        /// </summary>
        public void Draw()
        {
            // Draw the board with pieces in it using the output provider
            outputProvider.Write(ToString());
        }

        /// <summary>
        /// Get a string representation of the board
        /// </summary>
        /// <returns>The board as a string</returns>
        public override string ToString()
        {
            // Return what the board should look like when printed as a string
            // Use the StringBuilder class to build each line of the board
            throw new NotImplementedException();
        }

        /// <summary>
        /// Helper function to determine if there are pieces between two positions
        /// Useful since most pieces can't move through other pieces
        /// This should NOT check the pieces at p1 or p2, only squares between them
        /// </summary>
        /// <param name="p1">Position 1</param>
        /// <param name="p2">Position 2</param>
        /// <returns></returns>
        public bool ArePiecesBetween(Position p1, Position p2)
        {
            // validate the inputs!

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
