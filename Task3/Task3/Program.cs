using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program determines the average length of a word in the text.\nInput the text.");
            string str;
            str=Console.ReadLine();
            string str2 = "";
            List<string> Words = new List<string>();
            int Count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    str2 += str[i];
                    continue;
                }
                if (!str2.Equals(""))
                {
                    Words.Add(str2);
                    Count++;
                    str2 = "";
                }
            }
            int SumOfLength = 0;
            foreach (string s in Words)
            {
                SumOfLength += s.Length;
            }
            Console.WriteLine("Average l[]]]]]]]ength of a word in the text is {0}.\nPress any key for apl clossing . . . ", SumOfLength/Count);
            Console.ReadLine();
            return;
        }
    }
}
