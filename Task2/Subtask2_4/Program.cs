using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program initializes an array2D with rank 2 of random numbers from the interval (-10,10),\nand finds a sum of the elements are in even positions");
            Random r = new Random();
            int[,] Array2D = new int[4,4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    Array2D[i, j] = r.Next(-10, 10);
            int Sum = 0;
            Console.WriteLine("Array :");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(Array2D[i, j] + "  ");
                    if ((i+j)%2==0)
                        Sum += Array2D[i, j];
                }
            }
            Console.WriteLine("\nSum of the elements are in even positions is {0}\nPress any key for apl closing . . . ", Sum);
            Console.ReadKey();
            return;
        }
    }
}
