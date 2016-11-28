using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask5_3
{
    public class Round : Circle
    {
        public Round()
        {
            Name = "Raund";
            X = 0;
            Y = 0;
            Radius = 0;
        }
        public Round(int x, int y, int R)
        {
            X = x;
            Y = y;
            Radius = R;
            Name = "Raund";
        }
        public double Area
        {
            get
            {
                if (R == 0)
                    return 0;
                return Math.PI * R * R;
            }

        }
        public override string ToString()
        {
            return string.Format("{0} with center in ({1};{2})  and radius equals to {3},\ncircle length equals to {4} and with area {5}.\n",Name, X, Y, Radius,L,Area);
        }
    }
}
