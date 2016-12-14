using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)//todo "каждый второй человек" != "второй человек". На первый-второй рассчитайтесь...
        {
            Console.WriteLine("Введите количество человек в круге.");
            int N = int.Parse(Console.ReadLine());//todo необработанное исключение, если я введу не число
            Queue<int> Circle = new Queue<int>();
            for (int i = 0; i < N; i++)
                Circle.Enqueue(i + 1);
            foreach (int buf in Circle)
                Console.WriteLine("Person{0}", buf);
            int j = 1;
            while (Circle.Count != 1)
            {
                Console.WriteLine("Step{0}--------------", j);
                Circle.Enqueue(Circle.Dequeue());
                Circle.Dequeue();
                foreach (int n in Circle)
                    Console.WriteLine("Person{0}", n);
                j++;
            }
            Console.WriteLine("\nRezult :");
            foreach (int buf in Circle)
                Console.WriteLine("Person{0}", buf);
            Console.Write("Press any key for apl clossing . . .");
            Console.ReadKey();
            return;
        }
    }
}
