using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banqi.MVVM.Model.Pieces
{
    class HorseB : Piece
    {

        public override string Name => "HorseB";

        public override string ImagePath => @"~/../../Data/Xiangqi_hd1.png";       
        public override int Rank => -3;
    }
}
