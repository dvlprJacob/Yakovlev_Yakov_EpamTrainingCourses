using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask5_3
{
    public class Square : Reactangle
    {
        public Square(int side)
        {
            Name = "Square";
            Side = side;
        }
        public int Side
        {
            set
            {
                if (value > 0)
                    Height = value;
            }
            get
            {
                return Height;
            }
        }
        public new int Area
        {
            get
            {
                return Side * Side;
            }
        }
        public new int Perimetr
        {
            get
            {
                return Side * 2;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} with sides equals to {1}, area {2} and perimetr {3}\n", Name, Side, Area, Perimetr);
        }
    }
}
