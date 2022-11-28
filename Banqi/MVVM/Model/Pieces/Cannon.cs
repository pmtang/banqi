using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banqi.MVVM.Model.Pieces
{
    class Cannon : Piece
    {


        public override string Name => "Cannon";

        public override string ImagePath => @"~/../../Data/Xiangqi_cl1.png";       
        public override int Rank => 2;
    }
}
