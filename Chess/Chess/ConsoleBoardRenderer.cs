using Chess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    /// <summary>
    /// The ConsoleBoardRenderer class, used to render the board to the Console
    /// </summary>
    public class ConsoleBoardRenderer : IBoardRenderer
    {

        string newLine = "\n________________________________________________________\n                                                        ";

        /// <summary>
        /// Render the specified board
        /// </summary>
        /// <param name="board">The board</param>
        public void Render(IBoard board)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            // validate the arguments
            // if board is null, throw ArgumentNullException
            if (board == null)
            {
                throw new ArgumentNullException();
            }

            // draw the board to the console, however you see fit
            // each piece has a ToString() you can use to draw it

            // Use colors to make your output look prettier
            // Each piece has an owner so you can use that to drive the color
            // If you don't know how to do colors in the Console, look it up :)
            for (int i = 0; i < board.NumRows; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(newLine);
                for (int j = 0; j < board.NumColumns; j++)
                {
                    var position = new Position(i, j);
                    var currentPiece = board.GetPiece(position);

                    if (currentPiece == null)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("|     |");
                    }
                    else if (currentPiece.Owner.Color == PlayerColor.White)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("|");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"  {currentPiece.Label}  ");

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("|");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("|");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write($"  {currentPiece.Label}  ");

                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("|");
                    }
                }
            }
            Console.WriteLine(newLine);
        }
    }
}
