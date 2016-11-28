using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask5_3
{
    public class Ring : Round
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="outer"></param>
        /// <param name="inner"></param>
        public Ring(int x, int y, int outer, int inner)
        {
            Name = "Ring";
            X = x;
            Y = y;
            Radius = outer;
            InnerRadius = inner;
        }
        public int OuterRadius
        {
            get
            {
                return Radius;
            }
            set
            {
                if (value > 0)
                    Radius = value;
            }
        }
        public int InnerRadius { set; get; }
        public new double Area
        {
            get
            {
                if (Radius > 0 && (InnerRadius < Radius))
                    return (Math.PI * Radius * Radius - Math.PI * InnerRadius * InnerRadius);
                return 0;
            }
        }
        public new double L
        {
            get
            {
                if (Radius > 0 && InnerRadius < Radius)
                    return (2 * Math.PI * Radius + 2 * Math.PI * InnerRadius);
                return 0;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} with center in ({1};{2}), outer radius equals to {3},\ninner radius equals to {4}, area equals to {5} and circle length equals to {6}.\n",Name, X, Y, Radius, InnerRadius, Area, L);
        }
    }
}
