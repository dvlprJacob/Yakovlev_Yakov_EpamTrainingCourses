using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "";
                Console.WriteLine("Enter the number of rows to display images or 0 for exit.");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n-1; i++)
                {
                    str += " ";
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(str += "*");
                    str = str.Remove(0, 1) + "*";
                }
                Console.ReadKey();

            }
            catch(FormatException)
            {
                Console.WriteLine("Wrong Input.");
                Console.ReadKey();
                return;
            }
        }
    }
}
