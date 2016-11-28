using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask5_3
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
                Line T = new Line(0, 0, 1, 1);
                Console.WriteLine(T);
                Reactangle Four = new Reactangle(2, 3);
                Console.WriteLine(Four);
                Square Fi = new Square(2);
                Console.WriteLine(Fi);
            }
            catch (Exception e)
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
