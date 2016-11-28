using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User F = new User("J", "J", new DateTime(1996, 9, 17));
                Console.WriteLine(F);
                Employee S = new Employee("J", "J", new DateTime(1997, 10, 18), new DateTime(2015, 1, 20), "Software Engineer");
                Console.WriteLine(S);
                Employee T = new Employee(F, S.GetDateOfEmplt(), S.GetPost());
                Console.WriteLine(T);
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
        }
    }
}
