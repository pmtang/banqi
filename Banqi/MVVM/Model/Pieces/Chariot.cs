using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banqi.MVVM.Model.Pieces
{
    class Chariot : Piece
    {

        public override string Name => "Chariot";

        public override string ImagePath => @"~/../../Data/Xiangqi_rl1.png";       
        public override int Rank => 4;
    }
}
