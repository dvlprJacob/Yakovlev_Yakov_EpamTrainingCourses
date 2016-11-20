using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Subtask3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "";
                StringBuilder sb = new StringBuilder();
                Stopwatch sw1 = new Stopwatch();
                Console.WriteLine("Input number for cycles");
                int n = int.Parse(Console.ReadLine());
                sw1.Start();
                for (int i = 0; i < n; i++)
                {
                    str += "*";
                }
                sw1.Stop();
                Stopwatch sw2 = new Stopwatch();
                sw2.Start();
                for (int i = 0; i < n; i++)
                {
                    sb.Append("*");
                }
                sw2.Stop();
                Console.WriteLine("Addition operation time for string {0}.\nAddition operation time for StringBuilder {1}.", sw1.Elapsed, sw2.Elapsed);
                Console.WriteLine("Press any key for apl clossing . . . ");
                Console.ReadKey();
                return;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Press any key for apl clossing . . . ");
                Console.ReadKey();
                return;
            }
        }
    }
}
