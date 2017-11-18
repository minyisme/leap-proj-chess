using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Interfaces
{
    /// <summary>
    /// The IBoardRenderer interface, represents something that renders the board
    /// </summary>
    public interface IBoardRenderer
    {
        /// <summary>
        /// Render the board
        /// </summary>
        /// <param name="board">The board</param>
        void Render(Board board);
    }
}
