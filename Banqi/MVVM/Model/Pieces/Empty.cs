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

        public override string ImagePath => @"~/../../Data/Xiangqi_nn1.png";

        public override bool Revealed => true;
    }
}
