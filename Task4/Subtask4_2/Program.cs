using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask4_2
{
    public class Triangle
    {
        int side1, side2, side3;
        public Triangle()
        {
            a = 0;
            b = 0;
            c = 0;
        }
        public Triangle(int a, int b, int c)
        {
            if (a+b>c && a+c>b && b+c>a)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                this.a = 0;
                this.b = 0;
                this.c = 0;
            }
        }
        public int a
        {
            get
            {
                return this.side1;
            }
            set
            {
                this.side1 = value;
            }
        }
        public int b
        {
            get
            {
                return this.side2;
            }
            set
            {
                this.side2 = value;
            }
        }
        public int c
        {
            get
            {
                return side3;
            }
            set
            {
                this.side3 = value;
            }
        }
        public double Perimetr
        {
            get
            {
                if(a>0 && b>0 && c>0)
                    return a + b + c;
                return 0;
            }
        }
        public double Area
        {
            get
            {
                if (Perimetr > 0)
                {
                    double P = this.Perimetr / 2;
                    return Math.Sqrt(P * (P - a) * (P - b) * (P - c));
                }
                return 0;
            }
        }
        public override string ToString()
        {
            return string.Format("Triangle with sides a= {0}, b= {1}, c= {2}.",a,b,c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle T = new Triangle(3,3,1);
            Console.WriteLine(T);
            Console.WriteLine("Area equall {0}\nPerimetr equall {1}\nPress any key for ap clossing . . . ", T.Area, T.Perimetr);
            Console.ReadKey();
            return;
        }
    }
}
