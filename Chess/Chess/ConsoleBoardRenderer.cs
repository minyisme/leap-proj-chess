using Chess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    /// <summary>
    /// The ConsoleBoardRenderer class, renders the board to the console
    /// </summary>
    public class ConsoleBoardRenderer : IBoardRenderer
    {
        /// <summary>
        /// Render the board to the console
        /// Each piece on the board has a label which can be used to draw it
        /// Each piece on the board has an owner, which has a color, which can be used to change the piece color when drawing it
        /// The rest of how the board looks is up to you
        /// </summary>
        /// <param name="board">The board</param>
        public void Render(Board board)
        {
            throw new NotImplementedException();
        }
    }
}
