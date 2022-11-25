using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banqi.MVVM.Model
{
    [Flags]
    public enum MoveState : byte
    {
        None        = 1 << 0, // 00000001
        Selected    = 1 << 1, // 00000010
        Invalid     = 1 << 2, // 00000100
        Moved       = 1 << 3, // 00001000
        Capture     = 1 << 4, // 00010000
        //D           = 1 << 5, // 00100000
        //D           = 1 << 6, // 01000000
        //D           = 1 << 7  // 10000000
    }
}
