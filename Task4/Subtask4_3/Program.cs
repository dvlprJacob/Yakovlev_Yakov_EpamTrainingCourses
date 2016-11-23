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
        readonly int Age;
        public User()
        {
            FName="";
            SName="";
            BDay = DateTime.Today;
            Age = 0;
        }
        public User(string FName,string SName)
        {
            this.FName = FName;
            this.SName = SName;
            this.BDay = DateTime.Today;
        }
        public User(string FName, string SName,int Year)
        {
            this.FName = FName;
            this.SName = SName;
            this.BDay = new DateTime(Year, 1, 1);
        }
        public int Years
        {
            get
            {
                if (BDay != null)
                    return DateTime.Today.Year - BDay.Year;
                return -1;
            }
        }
        public string ToString()
        {
            if(BDay!=null)
                return "First name is " + FName.ToString() + "\nSecond name is " + SName.ToString() + "\nBirth dite is " + BDay.ToString() + "\nYears is "+Years;
            return null;
        }
        public void Write()
        {
            if (ToString() != null)
                Console.WriteLine(ToString()+"\n");
            return;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User Alex = new User("Alex", "Sun");
            Alex.Write();
            User[] Arr = new User[3];
            Random r = new Random();
            for(int i=0;i<3;i++)
            {
                Arr[i] = new User("FName" + i.ToString(), "SName" + i.ToString(), r.Next(1950,1996));
            }
            foreach(User s in Arr)
            {
                s.Write();
            }

            int older = 0; ;
            for(int i=1;i<3;i++)
            {
                if (Arr[i].Years > Arr[older].Years)
                    older = i;
            }
            Console.WriteLine("Older user is\n{0}\nPress any key for apl clossing . . . ", Arr[older].ToString());
            Console.ReadKey();
            return;
        }
    }
}
