using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Round
    {
        int R;
        public Round()
        {
            X = 0;
            Y = 0;
            Radius = 0;
        }
        public Round(int x, int y, int R)
        {
            X = x;
            Y = y;
            Radius = R;
        }
        public void SetCoor(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int Radius
        {
            get
            {
                return R;
            }
            set
            {
                if (value >= 0)
                    R = value;
            }
        }
        public int X { get; set; }
        public int Y { get; set; }
        public double Area
        {
            get
            {
                if (R == 0)
                    return 0;
                return Math.PI * R * R;
            }

        }
        public double L
        {
            ///<summary>
            ///property returns the length of the circumscribed circle
            ///</summary>
            get
            {
                return 2 * Math.PI * R;
            }
        }
        public override string ToString()
        {
            return string.Format("Round with center in ({0};{1})  and radius equall {2}", X, Y, Radius);
        }
    }
}
