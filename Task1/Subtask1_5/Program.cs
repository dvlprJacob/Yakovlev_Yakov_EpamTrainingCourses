using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int j = 0;
            Console.WriteLine("The program calculates the sum of positive integers less than one hundred multipless of three or five.");
            for(int i=0;i<1000;i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }
            Console.Write("Sum = "+sum+"\nPress any key for apl closing.  ");
            Console.ReadKey();
            return;
        }
    }
}
