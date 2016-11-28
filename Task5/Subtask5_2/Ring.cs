using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask5_2
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
        public Ring(int x,int y,int outer,int inner)
        {
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
            return string.Format("Ring with center in ({0};{1}), outer radius equals to {2},\ninner radius equals to {3}, and with area equals to {4}.", X, Y, Radius, InnerRadius, Area);
        }
    }
}
