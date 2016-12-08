using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Employee : User
    {
        DateTime DateOfEmplt;
        string Post = "";
        DateTime WorkExperience
        {
            get
            {
                if (DateOfEmplt != null)
                    return new DateTime(DateTime.Today.Year - DateOfEmplt.Year, Math.Abs(DateTime.Today.Month - DateOfEmplt.Month), Math.Abs(DateTime.Today.Day - DateOfEmplt.Day));
                return new DateTime();
            }
        }
        public DateTime GetDateOfEmplt()
        {
            return this.DateOfEmplt;
        }
        public string GetPost()
        {
            return this.Post;
        }
        public Employee()
        {
            BDay = new DateTime();
            DateOfEmplt = new DateTime();
        }
        /// <summary>//todo какой смысл писать пустые комментарии?
        /// 
        /// </summary>
        /// <param name="User"></param>
        /// <param name="DateOfEmplt"></param>
        /// <param name="Post"></param>
        public Employee(User User,DateTime DateOfEmplt,string Post)
        {
            if(User!=null)
            {
                this.Post = Post;
                this.DateOfEmplt = DateOfEmplt;//todo возможна ситуация, когда день рождения пользователя позже его даты начала работы
                this.FName = User.FirstName;
                this.SName = User.SecondName;
                this.BDay = User.BirthDay;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FName"></param>
        /// <param name="SName"></param>
        /// <param name="BDay"></param>
        /// <param name="DateOfEmplt"></param>
        /// <param name="Post"></param>
        public Employee(string FName,string SName,DateTime BDay,DateTime DateOfEmplt, string Post)
        {
            this.FName = FName;
            this.SName = SName;
            this.BDay = BDay;
            this.Post = Post;
            this.DateOfEmplt = DateOfEmplt;
        }
        public bool EqualToPost(string buf)
        {
            if (this.Post.Equals(buf))
                return true;
            return false;
        }
        public override string ToString()
        {
            if (this != null)
                return string.Format("First name is {0}\nSecond name is {1}\nBirth dite is {2}\nYears is {3}\nDate of employment is {4}\nWork experience is {5}\nPost is {6}\n", FName, SName, BDay, Years.Year, DateOfEmplt, WorkExperience, Post);
            return "This employment dose not exist.";
        }
    }
}
