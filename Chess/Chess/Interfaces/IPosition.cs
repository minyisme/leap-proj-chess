using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Interfaces
{
    /// <summary>
    /// The position interface, represents a position abstraction
    /// </summary>
    public interface IPosition
    {
        int Row { get; }
        int Column { get; }
    }
}
