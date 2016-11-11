using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str1 = "";
                string str2 = "";
                Console.WriteLine("Enter the number of rows to display image.");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n - 1; i++)
                {
                    str1 += " ";
                }
                str2 = str1 + "*";
                string str3 = "*";
                for (int i = 0; i < n; i++)
                {
                    str3 += "*";
                    Console.WriteLine(str2);
                    str1 = str1.Remove(0, 1) + "*";
                    str2 += "\n" + str1 + str3;
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Wrong Input ! Press any key for apl closing.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Press any key for apl closing.   ");
            Console.ReadKey();
            return;
        }
    }
}
