using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask5_3
{
    public class Reactangle : Shape
    {
        protected int Height { set; get; }
        int Width { set; get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        public Reactangle() { }
        public Reactangle(int a,int b)
        {
            Name = "Rectangle";
            Height = a;
            Width = b;
        }
        public int Area
        {
            get
            {
                return Height*Width;
            }
        }
        public int Perimetr
        {
            get
            {
                return Height + Width;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} with height {1}, width {2},area {3} and perimetr equals to {4}\n", Name, Height, Width, Area, Perimetr);
        }
    }
}
