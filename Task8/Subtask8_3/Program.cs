using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
/// <summary>
/// Поиск элемента соответствующим способом реализованы в Subtask[порядок].
/// </summary>
namespace Subtask8_3
{
    internal static class Program
    {
        //Delegate for subtask2
        public delegate int Method(int[] _array,int value);
        //Delegate for subtask3
        public delegate int AnonymousMethod(int[] _array, int value);
        //Delegate for subtask4
        public delegate int LymbdaMethod(int[] _array, int value);
        /// <summary>
        /// Возвращает индекс искомого элемента value в массиве _array, возвращает -1, если такового нет.
        /// </summary>
        /// <param name="_array"></param>
        /// <returns></returns>
        public static int GetIndexOfElement(int[] _array, int value)
        {
            if (!_array.Equals(null))
            {
                for (int i = 0; i < _array.Count(); i++)
                {
                    if (_array[i] == value)
                        return i;
                }
            }
            return -1;
        }
        public static void Subtask1(int[] _array,int value)
        {
            Stopwatch RunTime = new Stopwatch();
            List<double> ArrayForMedian = new List<double>();

            int rezult = -1;
            RunTime.Start();

            for (int i = 0; i < 40; i++)
            {
                RunTime.Restart();
                rezult = GetIndexOfElement(_array, value);
                ArrayForMedian.Add(RunTime.Elapsed.TotalMilliseconds);
            }
    
            RunTime.Stop();
            double ftime = ArrayForMedian[0];
            double median = ArrayForMedian.Average();

            Console.WriteLine("The first method has worked for {0} milliseconds,\nwith median measurement {1}",ftime, median);
            if (rezult != -1)
                Console.WriteLine("Index of value {0} is {1}.\n", value, rezult+1);
            else
                Console.WriteLine("Value {0} is not exist in this array.\n", value);
        }
        public static void Subtask2(int[] _array,int value)
        {
            Stopwatch RunTime = new Stopwatch();
            List<double> ArrayForMedian = new List<double>();
            int rezult = -1;
            RunTime.Start();
            
            for (int i=0;i<40;i++)
            {
                RunTime.Restart();
                //Я так понял, что инициализацию делегата нужно писать после начала отсчета времени.
                Method IsIn = new Subtask8_3.Program.Method(GetIndexOfElement);
                rezult = IsIn.Invoke(_array, value);
                ArrayForMedian.Add(RunTime.Elapsed.TotalMilliseconds);
            }

            RunTime.Stop();
            double ftime = ArrayForMedian[0];
            ArrayForMedian.Sort();
            double median = ArrayForMedian[20];

            Console.WriteLine("The second method has worked for {0} milliseconds,\nwith median measurement {1} milliseconds.",ftime, median);
            if (rezult != -1)
                Console.WriteLine("Index of value {0} is {1}.\n", value, rezult+1);
            else
                Console.WriteLine("Value {0} is not exist in this array.\n", value);
        }
        public static void Subtask3(int[] _array,int value)
        {
            Stopwatch RunTime = new Stopwatch();
            List<double> ArrayForMedian = new List<double>();
            int rezult = -1;
            RunTime.Start();

            for (int i = 0; i < 40; i++)
            {
                RunTime.Restart();
                AnonymousMethod IsIn = delegate (int[] array, int _value)
                {
                    return GetIndexOfElement(array, _value);
                };
                rezult = IsIn(_array, value);
                ArrayForMedian.Add(RunTime.Elapsed.TotalMilliseconds);
            }

            RunTime.Stop();
            double ftime = ArrayForMedian[0];
            ArrayForMedian.Sort();
            double median = ArrayForMedian[20];

            Console.WriteLine("The third method has worked for {0} milliseconds,\nwith median measurement {1} milliseconds.", ftime, median);
            if (rezult != -1)
                Console.WriteLine("Index of value {0} is {1}.\n", value, rezult + 1);
            else
                Console.WriteLine("Value {0} is not exist in this array.\n", value);
        }
        public static void Subtask4(int[] _array,int value)
        {
            Stopwatch RunTime = new Stopwatch();
            List<double> ArrayForMedian = new List<double>();
            int rezult = -1;
            RunTime.Start();

            for (int i = 0; i < 40; i++)
            {
                RunTime.Restart();
                LymbdaMethod IsIn = (array, _value) => GetIndexOfElement(array,_value);
                rezult = IsIn(_array, value);
                ArrayForMedian.Add(RunTime.Elapsed.TotalMilliseconds);
            }

            RunTime.Stop();
            double ftime = ArrayForMedian[0];
            ArrayForMedian.Sort();
            double median = ArrayForMedian[20];

            Console.WriteLine("The fourth method has worked for {0} milliseconds,\nwith median measurement {1} milliseconds.", ftime, median);
            if (rezult != -1)
                Console.WriteLine("Index of value {0} is {1}.\n", value, rezult + 1);
            else
                Console.WriteLine("Value {0} is not exist in this array.\n", value);
        }
        public static bool IsIn(int[] _arr,int val)
        {
            if (!_arr.Equals(null))
            {
                for (int i = 0; i < _arr.Count(); i++)
                {
                    if (_arr[i] == val)
                        return true;
                }
            }
            return false;
        }
        
        //Расшиеннный метод возвращает коллекцию индексов для вхождений value в source.
        public static IEnumerable<int> IndexesWhere<T>(this IEnumerable<T>  source,Func<T,bool> predicate)
        {    
            int index = 0;
            foreach(T item in source)
            {
                if (predicate(item))
                    yield return index;
                index++;
            }
        }
        public static void Subtask5(int[] _array,int value)
        {
            Stopwatch RunTime = new Stopwatch();
            List<double> ArrayForMedian = new List<double>();

            RunTime.Start();
            List<int> buf = new List<int>(_array);

            //Для данного метода целесообразней сформировать запрос вне цикла и после начала отсчета времени.
            var indexes = buf.Select((item, index) => new { Item = item, Index = index }).Where(n => n.Item == value).Select(n => n.Index);
            for (int i = 0; i < 40; i++)
            {
                foreach (int item in indexes)
                { }
                ArrayForMedian.Add(RunTime.Elapsed.TotalMilliseconds);
                RunTime.Restart();
            }
            RunTime.Stop();
            double ftime = ArrayForMedian[0];
            ArrayForMedian.Sort();
            double median = ArrayForMedian[20];

            Console.WriteLine("The fifth method has worked for {0} milliseconds,\nwith median measurement {1} milliseconds.", ftime, median);
            if (indexes.Count() > 0)
            {
                Console.Write("Indexes of value {0} is : ", value);
                foreach (var item in indexes)
                    Console.Write(item + 1+", ");
                Console.WriteLine();
            }
            else
                Console.WriteLine("Value {0} is not exist in this array.\n", value);
        }
        static void Main(string[] args)
        {
            try
            {
                Random R = new Random();
                int[] _array = new int[800];
                for (int i = 0; i < 800; i++)
                    _array[i] = R.Next(-1000,1000);
                foreach (int item in _array)
                    Console.Write(item+"  ");
                Console.WriteLine("\n_______________________________________________\nInput value for find it in array.");
                int value=int.Parse(Console.ReadLine());

                Subtask1(_array,value);
                
                Subtask2(_array, value);

                Subtask3(_array, value);

                Subtask4(_array, value);

                Subtask5(_array, value);

                Console.ReadKey();
                return;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return;
            }
        }
    }
}
