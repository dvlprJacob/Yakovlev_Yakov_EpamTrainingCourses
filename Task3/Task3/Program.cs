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
            string[] words = str.Split(new[] { ' ', '!', '?', ':', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);//todo не пойдет, используй методы класса Char (IsDigit, IsLetter итп)
            int SumOfLength = 0;
            foreach(string s in words)
            {
                SumOfLength += s.Length;
            }
            int AverageLength = SumOfLength / words.Count();
            Console.WriteLine("Average l[]]]]]]]ength of a word in the text is {0}.\nPress any key for apl clossing . . . ",AverageLength);
            Console.ReadLine();
            return;
        }
    }
}
