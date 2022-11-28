using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banqi.MVVM.Model.Pieces
{
    class Soldier : Piece
    {

        public override string Name => "Soldier";

        public override string ImagePath => @"~/../../Data/Xiangqi_sl1.png";
 
        public override int Rank => 1;
    }
}
