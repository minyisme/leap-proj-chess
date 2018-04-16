using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Interfaces
{
    public interface IMove
    {
        IPosition Source { get; set; }
        IPosition Dest { get; set; }
    }
}
