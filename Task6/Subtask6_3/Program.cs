using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DinamicArray A = new DinamicArray(new List<int>(new int[] { 1 }));
            A.AddRange(new List<int> { 2,3,4,5,6,7,8});
            Console.WriteLine("Initialized\n");
            Console.WriteLine(A);
            Console.Write("\nRemove value 4\n");
            A.Remove(4);
            Console.WriteLine(A);
            Console.Write("\nInsert in third position value 4\n");
            A.Insert(4, 2);
            Console.WriteLine(A);
            Console.Write("\nInsert in 9 position value 10\n");
            A.Insert(10, 8);
            Console.WriteLine(A);
            Console.Write("\nPress any key for apl clossing . . .");
            Console.ReadKey();
            return;
        }
    }
}
