using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            sln:
            try
            {
                Console.WriteLine("Enter the number of rows to display images or 0 for exit.");
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                    return;
                string str="";
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(str + "*");
                    str += "*";
                }
                goto sln;
            }
            catch(FormatException)
            {
                Console.WriteLine("Wrong Input. Repeat.\n");
                goto sln;
            }
        }
    }
}
