using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Round F = new Round(0, 0, 1);
            Console.WriteLine(F);
            Console.WriteLine("Area equall {0}\nLength of the circumscribed circle equall {1}\nPress any key for ap clossing . . . ", F.Area,F.L);
            Console.ReadKey();
            return;
        }
    }
}
