using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banqi.MVVM.Model.Pieces
{
    class GeneralB : Piece
    {

        public override string Name => "GeneralB";
        public override string ImagePath => @"~/../../Data/Xiangqi_gd1.png";       
        public override int Rank => -7;
    }
}
