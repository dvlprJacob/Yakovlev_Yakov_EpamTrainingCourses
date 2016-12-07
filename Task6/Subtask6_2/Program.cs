using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на английском.");
            string Text = Console.ReadLine();
            
            List<string> words = new List<string>(Text.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries));
            List<KeyValuePair<int, string>> Words = new List<KeyValuePair<int, string>>();
            for (int i=0;i<words.Count;i++)
            {
                int counter = 1;
                for(int j=i+1;j<words.Count;j++)
                {
                    if(words[i]==words[j])
                    {
                        counter++;
                        words.RemoveAt(j);
                    }
                }
                Words.Add(new KeyValuePair<int, string>(counter, words[i]));
            }
            for(int i=0;i<Words.Count;i++)
            {
                Console.WriteLine("{0} - встречается {1} раз", Words[i].Value, Words[i].Key);
            }
            Console.Write("Press any key for apl clossing . . .");
            Console.ReadKey();
            return;
        }
    }
}
