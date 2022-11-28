using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banqi.MVVM.Model.Pieces
{
    class SoldierB : Piece
    {

        public override string Name => "SoldierB";

        public override string ImagePath => @"~/../../Data/Xiangqi_sd1.png";
    
        public override int Rank => -1;

    }
}
