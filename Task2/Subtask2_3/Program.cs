using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program initializes an array of length 10 random numbers from the interval (-10,10),\nand finds a sum of non-negative elements.");
            Random r = new Random();
            int[] Array = new int[10];
            for(int i=0;i<10;i++)
            {
                Array[i] = r.Next(-10, 10);
            }
            int Sum = 0;
            Console.WriteLine("Array :");
            foreach(int it in Array)
            {
                Console.Write(it+"; ");
                if (it > 0)
                    Sum += it;
            }
            Console.WriteLine("\nSum of non-negative array elements is {0}\nPress any key for apl closing . . . ", Sum);
            Console.ReadKey();
            return;
        }
    }
}
