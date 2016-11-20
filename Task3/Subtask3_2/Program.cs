using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Subtask3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Program doubles all the characters in the first line of the introduced belonging second string.\nInput first text.");
                string str = Console.ReadLine();
                Console.WriteLine("Input second string.");
                string substr = Console.ReadLine();
                for (int i = 0; i <str.Length; i++)
                {
                    if (substr.Contains(str[i]))
                        str = str.Insert(i + 1, str[i++].ToString());
                }
                Console.WriteLine("Rezult :  {0}", str);
                Console.WriteLine("Press any key for apl clossing.");
                Console.ReadKey();
                return;
            }
            catch(Exception e)
            {
                Console.Write("Warning! {0}", e);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Press any key for apl clossing . . . ");
            Console.ReadKey();
            return;
        }
    }
}
