using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask8_2
{
    static class Program
    {
        public static bool IsPositiveInteger(this string _string)
        {
            int i = 0;
            if (_string[i] != '0' && _string[i]!='-' && !char.IsLetter(_string[i]))
            {
                while (i < _string.Count())
                {
                    if (!char.IsNumber(_string[i]))
                        return false;
                    i++;
                }
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input string.");
            string _string = Console.ReadLine();

            while (_string != "")
            {
                if (_string.IsPositiveInteger())
                    Console.WriteLine("This string is positive integer digit.\n");
                else
                    Console.WriteLine("This string is not positive integer digit.\n");

                Console.WriteLine("Input string or press Enter for continue.");
                _string = Console.ReadLine();
            }

            Console.WriteLine("Press any key for apl clossing . . . ");
            Console.ReadKey();
            return;
        }
    }
}
