using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banqi.MVVM.Model.Pieces
{
    class Elephant : Piece
    {

        public override string Name => "Elephant";

        public override string ImagePath => @"~/../../Data/Xiangqi_el1.png";       
        public override int Rank => 5;
    }
}
