using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask4_2
{
    public class Triangle
    {
        int side1, side2, side3;//todo с полями разрешается работать только в соответствующих свойствах
        public Triangle()
        {
            side1 = 0;
            side2 = 0;
            side3 = 0;
        }
        public Triangle(int a, int b, int c)
        {
            if (a+b>c && a+c>b && b+c>a)
            {
                this.side1 = a;
                this.side2 = b;
                this.side3 = c;
            }
            else
            {
                side1 = 0;
                side2 = 0;
                side3 = 0;
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
        public string ToString()
        {
            return "Triangle with sides a=" + a.ToString() + ", b=" + b.ToString() + ", c=" + c.ToString() + ".";
        }
        public void Write()
        {
            Console.WriteLine(this.ToString());//todo this лишнее, из метода класса доступны все методы данного класса
            return;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle T = new Triangle(3,3,1);
            Console.WriteLine(T);
            T.Write();
            Console.WriteLine("Area equall {0}\nPerimetr equall {1}\nPress any key for ap clossing . . . ", T.Area, T.Perimetr);
            Console.ReadKey();
            return;
        }
    }
}
