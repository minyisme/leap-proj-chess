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
        /// <summary>
        /// Render the specified board
        /// </summary>
        /// <param name="board">The board</param>
        public void Render(IBoard board)
        {
            // validate the arguments
            // if board is null, throw ArgumentNullException

            // draw the board to the console, however you see fit
            // each piece has a ToString() you can use to draw it

            // Use colors to make your output look prettier
            // Each piece has an owner so you can use that to drive the color
            // If you don't know how to do colors in the Console, look it up :)
            throw new NotImplementedException();
        }
    }
}
