using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask5_3
{
    public class Circle : Shape
    {
        protected int R;
        public int X { get; set; }
        public int Y { get; set; }
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
        public double L
        {
            get
            {
                return 2 * Math.PI * R;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} with center in ({1};{2}), radius equals to {3} and circle length equals to {4}.\n",Name, X, Y, Radius, L);
        }
    }
}
