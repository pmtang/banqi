using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banqi.MVVM.Model
{
    abstract class Piece
    {
        public virtual string Name { get; set; } = "";
        public virtual int Rank { get; set; } = 0;


        public virtual bool Revealed { get; set; } = false;
        //public Uri ImageUri { get; set; } = new Uri("C:\\Users\\tangP\\source\\repos\\Banqi\\Banqi\\MVVM\\Data\\Xiangqi_General_Red.png");
        public virtual string ImagePath { get; } = @"";

        public Piece()
        {
        }
    }
}
