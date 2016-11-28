using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask4_3
{
    public class User
    {
        string FName, SName;
        DateTime BDay;
        public User()
        {
            FName="";
            SName="";
            BDay = DateTime.Today;
            //Возраст я реализовал в виде свойства Years
        }
        public User(string FName,string SName)
        {
            this.FName = FName;
            this.SName = SName;
            this.BDay = DateTime.Today;
        }
        public User(string FName, string SName,DateTime BDay)
        {
            this.FName = FName;
            this.SName = SName;
            this.BDay = BDay;
        }
        public DateTime Years
        {
            get
            {
                if (BDay != null)//todo это условие всегда true, потому что DateTime - не ссылочного типа и не может принимать значение null
                {
                    return new DateTime(BDay.Year, BDay.Month, BDay.Day);
                }
                throw new Exception("У пользователя не инициализирован день рождения");//todo не должен приводить к исплючительной ситуации (см. лекцию)
            }
        }
        public override string ToString()
        {
            if(BDay!=null)
                return string.Format("First name is {0}\nSecond name is {1}\nBirth dite is {2}\nYears is {3}",FName,SName,BDay,Years);
            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User Alex = new User("Alex", "Sun");
            Console.WriteLine(Alex);
            User[] Arr = new User[3];
            Random r = new Random();
            for(int i=0;i<3;i++)
            {
                Arr[i] = new User("FName" + i.ToString(), "SName" + i.ToString(), new DateTime(r.Next(1950,2000),r.Next(1,12),r.Next(1,31)));
            }
            foreach(User s in Arr)
            {
                Console.WriteLine(s);
            }

            int older = 0; ;
            for(int i=1;i<3;i++)
            {
                if (Arr[i].Years < Arr[older].Years)
                    older = i;
            }
            Console.WriteLine("Older user is\n{0}\nPress any key for apl clossing . . . ", Arr[older]);
            Console.ReadKey();
            return;
        }
    }
}
