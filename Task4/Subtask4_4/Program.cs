using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask4_4
{
    public class MyString
    {
        char[] Symbols;
        int Count;
        public MyString()
        {
            Symbols = new char[0];
        }
        public MyString(char[] s)
        {
            this.Count = s.Count();
            Symbols = new char[Count];
            for (int i = 0; i < this.Count; i++)
            {
                this.SetSymbol(i, s[i]);
            }
        }
        public MyString(MyString s1, MyString s2)
        {
            this.Count = s1.Count + s2.Count;
            this.Symbols = new char[this.Count];
            for (int i = 0; i < s1.Count; i++)
            {
                this.SetSymbol(i, s1.Symbols[i]);
            }
            int j = 0;
            for (int i = s1.Count; i < this.Count; i++)
            {
                this.SetSymbol(i, s2.Symbols[j]);
                j++;
            }
        }
        public MyString(MyString s1)
        {
            this.Count = s1.Count;
            this.Symbols = new char[this.Count];
            for (int i = 0; i < s1.Count; i++)
            {
                this.SetSymbol(i, s1.Symbols[i]);
            }
        }
        public MyString(string str)
        {
            this.Count = str.Count();
            Symbols = new char[Count];
            for (int i = 0; i < Count; i++)
            {
                Symbols[i] = str[i];
            }
        }
        public int Length
        {
            get
            {
                return this.Symbols.Length;
            }
            set
            {
                if (value >= 0)
                    this.Count = value;
            }
        }
        public void SetSymbol(int ind, char c)
        {
            if (this.Length >= ind)
            {
                this.Symbols[ind] = c;
            }
        }
        public static bool IsEmpty(MyString obj)
        {
            if (obj.Length == 0 && obj.Symbols.Length == 0)
                return true;
            return false;
        }
        public void Write()
        {
            if (Count > 0)
                Console.WriteLine(this.Symbols);
        }

        public static MyString operator + (MyString str1, MyString str2)
        {
            return new MyString(str1,str2);
        }
        public static bool operator ==(MyString str1,MyString str2)
        {
            if (str1.Length!=str2.Length)
                return false;
            for(int i=0;i<str1.Length;i++)
            {
                if (str1.Symbols[i] != str2.Symbols[i])
                    return false;
            }
            return true;
        }
        public static bool operator !=(MyString str1,MyString str2)
        {
            if (str1.Length != str2.Length)
                return true;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1.Symbols[i] != str2.Symbols[i])
                    return true;
            }
            return false;
        }
        public static explicit operator MyString(string obj)
        {
            return new MyString(obj);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyString str=new MyString("FBI");
            MyString str2 = new MyString(new char[] { 'F', 'B', 'I' });
            str.Write();
            Console.WriteLine(str.Length);
            str2.Write();
            Console.WriteLine(str2.Length);
            MyString str3=new MyString();
            if (str == (MyString)"FBI" && MyString.IsEmpty(str3))
            {
                str3 = str + str2;
                str3.Write();
                Console.WriteLine(str3.Length);
            }
            Console.WriteLine("Press any key for apl clossing . . . ");
            Console.ReadKey();
            return;
        }
    }
}
