using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banqi.MVVM.Model.Pieces
{
    class ElephantB : Piece
    {


        public override string Name => "ElephantB";

        public override string ImagePath => @"~/../../Data/Xiangqi_ed1.png";       
        public override int Rank => -5;
    }
}
