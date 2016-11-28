using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Round S = new Round(0, 0, 2);
                Console.WriteLine(S);
                Ring F = new Ring(0, 0, 2, 1);
                Console.WriteLine(F);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.Write("Press any key for apl clossing . . . ");
                Console.ReadKey();
            }
            return;
        }
    }
}
