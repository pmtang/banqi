using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banqi.MVVM.Model.Pieces
{
    class CannonB : Piece
    {


        public override string Name => "CannonB";

        public override string ImagePath => @"~/../../Data/Xiangqi_cd1.png";       
        public override int Rank => -2;
    }
}
