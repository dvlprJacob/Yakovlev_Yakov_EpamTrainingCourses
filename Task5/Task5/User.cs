using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class User
    {
        protected string FName;
        protected string SName;
        protected DateTime BDay;
        public User()
        {
            FName = "";
            SName = "";
            BDay = DateTime.Today;
            //Возраст я реализовал в виде свойства Years
        }
        public User(string FName, string SName)
        {
            this.FName = FName;
            this.SName = SName;
            this.BDay = DateTime.Today;
        }
        public User(string FName, string SName, DateTime BDay)
        {
            this.FName = FName;
            this.SName = SName;
            this.BDay = BDay;
        }
        public string FirstName
        {
            get
            {
                return this.FName;
            }
        }
        public string SecondName
        {
            get
            {
                return this.SName;
            }
        }
        public DateTime Years
        {
            get
            {
                if (BDay != null)
                {
                    return new DateTime(DateTime.Today.Year-BDay.Year, Math.Abs(DateTime.Today.Month-BDay.Month), Math.Abs(DateTime.Today.Day-BDay.Day));
                }
                throw new Exception("У пользователя не инициализирован день рождения");
            }
        }
        public DateTime BirthDay
        {
            get
            {
                return this.BDay;
            }
        }
        public bool EqualToFName(string buf)
        {
            if (this.FirstName.Equals(buf))
                return true;
            return false;
        }
        public override string ToString()
        {
            if (BDay != null)
                return string.Format("First name is {0}\nSecond name is {1}\nBirth dite is {2}\nYears is {3}\n", FName, SName, BDay, Years.Year);
            return null;
        }
    }
}

