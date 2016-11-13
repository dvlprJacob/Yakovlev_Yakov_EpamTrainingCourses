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
            int[,,] Array3D = new int[3, 3, 3];
            ArrayInicial(Array3D);
            Array3DShow(Array3D);
            Console.WriteLine("All the negative elements are replaced by zeros.");
            NegativElmntsReplcdByZero(Array3D);
            Array3DShow(Array3D);
            Console.WriteLine("Press any key for apl closing . . . ");
            Console.ReadKey();
            return;
        }
        static void ArrayInicial(int[,,] arr)
        {
            Random r = new Random();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    for (int k = 0; k < 3; k++)
                        arr[i, j, k] = r.Next(-10,10);
        }
        static void Array3DShow(int[,,] arr)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Values for plane {0}", j + 1);
                    for (int k = 0; k < 3; k++)
                        Console.WriteLine("elem[{0},{1},{2}]={3}", i + 1, j + 1, k + 1, arr[i, j, k]);
                }
            }
        }
        static void NegativElmntsReplcdByZero(int[,,] arr)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                        if (arr[i, j, k] < 0)
                            arr[i, j, k] = 0;
                }
            }
        }
    }
}
