using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Subtask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Дано квадратное уравнение, в котором параметры а,b и с зависят от дейстительного h, которое вам необходимо ввести.\nНеобходимо вычислить, являются ли при данном h корни уравнения действительными.Введите h для того чтобы продолжить.");
            Console.Write(" h = ");
            string hh = Console.ReadLine();
            while (hh != "Выход")
            {
                double h = Convert.ToDouble(hh);
                double a;
                if (h == 0)
                {
                    a = Math.Sqrt(17);
                    Console.WriteLine("a = {0}\nb = 0\nc = 0\nD = 0\nЕдинственный действительный корень: x = 0", a);
                    continue;
                }
                double b;
                double c;
                double D;
                a = Math.Sqrt((Math.Abs(Math.Sin(8 * h)) + 17) / (Math.Pow((1 - Math.Sin(4 * h) * Math.Cos(h * h + 18)), 2)));
                b = 1 - Math.Sqrt(3 / (3 + Math.Abs(Math.Tan(a * h * h) - Math.Sin(a * h))));
                c = a * h * h * Math.Sin(b * h) + b * h * h * h * Math.Cos(a * h);
                D = b * b - 4 * a * c;
                if (D < 0)
                {
                    Console.WriteLine("Действительных корней нет.\na = {0}\nb = {1}\nc = {2}\nD = {3}\n", a, b, c, D);
                    break;
                }
                Console.WriteLine("Действительные корни есть.\na = {0}\nb = {1}\nc = {2}\nD = {3}\nx1 = {4}   x2={5}", a, b, c, D, (-b + Math.Sqrt(D) / 2 * a), (-b - Math.Sqrt(D) / 2 * a) + "\nЗадача выполнена.");
                Console.WriteLine("Для того чтобы продолжить введите 'Выход', либо новое значение h .");
                hh=Console.ReadLine();
            }
            return;
        }
    }
}
