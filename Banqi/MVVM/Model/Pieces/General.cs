using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banqi.MVVM.Model.Pieces
{
    class General : Piece
    {

        public override string Name => "General";
        public override string ImagePath => @"~/../../Data/Xiangqi_gl1.png";       
        public override int Rank => 7;
    }
}
