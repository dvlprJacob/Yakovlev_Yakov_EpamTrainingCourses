using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Collections.Specialized;

namespace Subtask1_6
{
    class Program
    {
        static void Main(string[] args)//todo не понял, каким образом можно убрать форматирование текста. Простявляет - ок, а вот с обратным действием проблемы.
        {
            Stopwatch swatch = new Stopwatch();
            swatch.Start();
            try
            {
                StreamReader sr = new StreamReader("TextFile1.txt");
                int length=System.IO.File.ReadAllLines("TextFile1.txt").Length;
                string[] param = new string[length+1];
                string ReaderBuf;
                int index = 0;
                while ((ReaderBuf = sr.ReadLine()) != null)
                {
                    param[index] = ReaderBuf;
                    index++;
                }
                for(int i=0;i<index;i++)
                {
                    Console.WriteLine(i.ToString() + " : " + param[i]);
                }
                Console.WriteLine("Params : ");
                Console.WriteLine("Press parametr index for switch,-1 for delet parametr or -2 for apl exit.");
                int n = int.Parse(Console.ReadLine());
                int[] state = { 0, 0, 0 };
                while (n != -2)
                {
                    if (n < length && n >=0 && state[n] == 0)
                    {
                        {
                            if (n >= 0 && n <= 2)
                            {
                                state[n] = 1;
                                string buf = param[n];
                                param[length] += param[n] + "; ";
                            }
                        }
                        for (int i = 0; i < length; i++)
                        {
                            Console.WriteLine(i.ToString() + " : " + param[i]);
                        }
                        Console.WriteLine("Params : {0}", param[length]);
                    }
                    if(n==-1)
                    {
                        Console.WriteLine("Press index for delet.");
                        n=int.Parse(Console.ReadLine());
                        state[n] = 0;
                        string buf = param[length];
                        buf = buf.Replace(param[n] + "; ", "");
                        param[length] = buf;
                        for (int i = 0; i < length; i++)
                        {
                            Console.WriteLine(i.ToString() + " : " + param[i]);
                        }
                        Console.WriteLine("Params : {0}", param[length]);
                    }
                    Console.WriteLine("Press parametr index for switch,-1 for delet parametr or -2 for apl exit.");
                    n = int.Parse(Console.ReadLine());
                }
                StreamWriter sw = new StreamWriter("Output.txt");
                for(int i=0;i<length-1;i++)
                {
                    sw.WriteLine(param[i]);
                }
                sw.Close();
                sr.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + "\nPress any key for apl closing.  ");
                Console.ReadKey();
            }
            swatch.Stop();
            Console.WriteLine("Apl working time is {0}.\nPress any key for apl closing.", swatch.Elapsed);
            Console.ReadKey();
            return;
        }
    }
}
