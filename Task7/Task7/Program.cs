using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        public delegate int Function(string s1, string s2);
        static int Comp(string s1, string s2)
        {
            if (s1.Length == s2.Length)
                return string.Compare(s1, s2);
            else
            {
                if (s1.Length > s2.Length)
                    return 1;
                return -1;
            }

        }
        static void Main(string[] args)
        {
            try
            {
                string[] Str = new string[] { "asdh", "bar", "barr", "bca", "mmnaa", "axssb", "acc", "abc", "aba" };
                Console.WriteLine("Words:");
                foreach (string s in Str)
                    Console.WriteLine(s);
                //Delegate initial
                Function Compare = Comp;
                for (int i = 0; i < Str.Length; i++)
                {
                    int j = i + 1;
                    while (j < Str.Length)
                    {
                        if (Compare.Invoke(Str[i], Str[j]) > 0)
                        {
                            string buf = Str[i];
                            Str[i] = Str[j];
                            Str[j] = buf;
                        }
                        j++;
                    }
                }
                Console.WriteLine("Sorted words:");
                foreach (string s in Str)
                    Console.WriteLine(s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Press any key for closing . . .  ");
                Console.ReadKey();
            }
        }
    }
}