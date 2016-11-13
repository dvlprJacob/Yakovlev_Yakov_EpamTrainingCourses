using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void QSort(int[] arr, int left, int right)
        {
            int x = arr[(left + right) / 2];
            int i = left;
            int j = right;
            do
            {
                while (arr[i] < x)
                    i++;
                while (arr[j] > x)
                    j--;
                if (i <= j )
                {
                    int c = arr[i];
                    arr[i] = arr[j];
                    arr[j] = c;
                    i++;
                    j--;
                }
            }
            while (i <= j);
            if (left < j)
                QSort(arr, left, j);
            if (i < right)
                QSort(arr, i,right);
            return;
        }
        static void FindMax(int[] arr)
        {
            int max = arr[0];
            int maxi = 0;
            for(int i=1;i<10;i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    maxi = i;
                }
            }
            Console.WriteLine("Max elem of array is elem[{0}]={1}", maxi + 1, max);
            return;
        }
        static void FindMin(int[] arr)
        {
            int min = arr[0];
            int mini = 0;
            for (int i = 1; i < 10; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    mini = i;
                }
            }
            Console.WriteLine("Min elem of array is elem[{0}]={1}", mini + 1, min);
            return;
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] Array = new int[10];
            for(int i=0;i<10;i++)
            {
                Array[i] = r.Next(10*(11+i));
            }
            Console.WriteLine("Program initializes an array of length 10 random numbers\n__________________________\nSource array");
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("elem[{0}]={1}", i+1, Array[i]);
            }
            FindMax(Array);
            FindMin(Array);
            Console.WriteLine("__________________________\nSorted array by fast recursive sorting");
            QSort(Array, 0, 9);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("elem[{0}]={1}", i+1, Array[i]);
            }
            Console.Write("Press any key for apl closing . . . ");
            Console.ReadKey();
        }
    }
}
