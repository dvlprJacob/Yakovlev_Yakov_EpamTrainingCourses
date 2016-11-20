using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu:
            {
                string str;
                Console.WriteLine("Enter 1 for input sides or 2 for exit.");
                str=Console.ReadLine();
                switch (str)
                {
                    case "1": goto sln;
                    case "2": return;
                    default: goto Menu;
                }
            }
            sln:
                {
                    int a;
                    int b;
                    string str;
                    Console.Write("Enter the side of the rectangle to calculate its area.\na= ");
                    try
                    {
                        str = Console.ReadLine();
                        a = int.Parse(str);
                    }
                    catch (FormatException)
                    {
                        Console.Write("Wrong Input !\nRepeat.");
                        goto Menu;//todo нужно стараться не использовать этот оператор. С ним стройность логики программы сильно усложняется.
                    }
                    try
                    {
                        Console.Write("b= ");
                        str = Console.ReadLine();
                        b = int.Parse(str);
                    }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong Input !\nRepeat.");
                    goto Menu;
                }
                Console.WriteLine("Area of the rectangle with sides {0} and {1} equal {2}", a, b, a * b);
                Console.ReadKey();
                goto Menu;
                }
        }
    }
}
