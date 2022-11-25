using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banqi.MVVM.Model.Pieces
{
    internal class Empty : Piece
    {
        //public override string Name => "";

        //public override int Rank => 0;

        public override bool Revealed => true;
    }
}
