using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banqi.MVVM.Model.Pieces
{
    class Advisor : Piece
    {

        public override string Name => "Advisor";

        public override string ImagePath => @"~/../../Data/Xiangqi_al1.png";       
        public override int Rank => 6;
    }
}
