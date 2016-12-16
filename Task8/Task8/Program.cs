using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    static class Program
    {
        public static int GetSumOfElems(this IEnumerable<int> _collection)//todo мы же говорили о обобщениях. Переписать методы GetSumOfElems одним методом.
        {
            if(!_collection.Equals(null))
            {
                int Sum = 0;
                foreach(int item in _collection)
                {
                    Sum += item;
                }
                return Sum;
            }
            throw new ArgumentNullException("Collection equals to null.");
        }
        public static double GetSumOfElems(this IEnumerable<double> _collection)
        {
            if (!_collection.Equals(null))
            {
                double Sum = 0;
                foreach (int item in _collection)
                {
                    Sum += item;
                }
                return Sum;
            }
            throw new ArgumentNullException("Collection equals to null.");
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Input array size for initial is by random values.\nSize = ");
                int n = int.Parse(Console.ReadLine());
                if(n<0)
                {
                    throw new FormatException();
                }
                int[] Arr = new int[n];
                Random R = new Random();

                for (int i = 0; i < n; i++)
                    Arr[i] = R.Next(-10, 10);

                Console.WriteLine("Array[{0}]:",n);

                foreach (int item in Arr)
                    Console.Write(item + "  ");

                Console.WriteLine("\nSum of elements equals to {0}", Arr.GetSumOfElems());
                Console.WriteLine("Press any key for apl clossing . . . ");
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Main(args);
            }
        }
    }
}
