using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banqi.MVVM.Model.Pieces
{
    class Horse : Piece
    {

        public override string Name => "Horse";

        public override string ImagePath => @"~/../../Data/Xiangqi_hl1.png";       
        public override int Rank => 3;
    }
}
