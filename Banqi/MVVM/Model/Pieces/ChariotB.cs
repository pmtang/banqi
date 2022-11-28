using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banqi.MVVM.Model.Pieces
{
    class ChariotB : Piece
    {


        public override string Name => "ChariotB";

        public override string ImagePath => @"~/../../Data/Xiangqi_rd1.png";       
        public override int Rank => -4;
    }
}
