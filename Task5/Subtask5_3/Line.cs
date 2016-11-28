using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask5_3
{
    class Line : Shape
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        public Line(int x1,int y1,int x2,int y2)
        {
            Name = "Line";
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }
        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            }
        }
        public override string ToString()
        {
            return string.Format("{0} passes through the points A({1};{2}) and B({3};{4}), length equals to {5}.\n", Name, X1, Y1, X2, Y2,Length);
        }
    }
}
