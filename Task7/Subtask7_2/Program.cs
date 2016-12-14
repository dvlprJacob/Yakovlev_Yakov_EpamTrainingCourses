using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Subtask7_2
{
    public class PersonEventArgs:EventArgs
    {
        public string Name { set; get; }
        private DateTime ComeTime;
        public DateTime ComingTime
        {
            get
            {
                return ComeTime;
            }
            set
            {
                if (value.Hour >= 0 && value.Hour <= 24)
                    ComeTime = value;
            }
        }
        public PersonEventArgs() { }
        public PersonEventArgs(string name,DateTime _ComeTime)
        {
            Name = name;
            ComingTime = _ComeTime;
        }
    }
    public class Person// todo каждый класс в отдельный файл!
    {
        public string Name { set; get; }
        public Person(string name)
        {
            Name = name;
        }
        public Person() { }
        public static event EventHandler<PersonEventArgs> SayHelloEvent;
        public static event EventHandler<PersonEventArgs> SayGoodbyeEvent;
        public void Ave(object sender,PersonEventArgs _person)
        {
            if (!(_person.Equals(null) && sender.Equals(null)))
            {
                if (_person.ComingTime.Hour<12)
                {
                    Console.WriteLine("Good morning,{0} - say {1}", _person.Name, Name);
                    return;
                }
                if(_person.ComingTime.Hour<17)
                {
                    Console.WriteLine("Good day,{0} - say {1}", _person.Name, Name);
                    return;
                }
                else
                {
                    Console.WriteLine("Good evening,{0} - say {1}", _person.Name, Name);
                    return;
                }
            }
            throw new ArgumentNullException("PersonEventArgs coming datetime is null");

        }
        public void SayGoodbye(object sender,PersonEventArgs _person)
        {
            Console.WriteLine("Goodbye,{0}. - say {1}.", _person.Name, Name);
        }
        public void Coming(DateTime _ComingTime)
        {
            try
            {
                Console.WriteLine("[{0} is coming.]", Name);
                if (SayHelloEvent!=null)
                {
                    PersonEventArgs _person = new PersonEventArgs(this.Name,_ComingTime);
                    SayHelloEvent(this, _person);
                }
                SayHelloEvent += Ave;
                SayGoodbyeEvent += SayGoodbye;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
        public void GoOut()
        {
            try
            {
                if (!SayGoodbyeEvent.Equals(null))
                {
                    Console.WriteLine("[{0} go to home.]", Name);
                    PersonEventArgs _person = new PersonEventArgs();
                    _person.Name = this.Name;
                    _person.ComingTime = DateTime.Now;
                    SayGoodbyeEvent -= SayGoodbye;
                    SayHelloEvent -= Ave;
                    if(SayGoodbyeEvent!=null)
                    {
                        SayGoodbyeEvent(this, _person);
                    }
               }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

    }
    class Program
    {
        public delegate void Act(object s,PersonEventArgs e);
        static void Main(string[] args)
        {
            try
            {
                Person p1 = new Person("Alex");
                Person p2 = new Person("Ben");
                Person p3 = new Person("Jack");
                p1.Coming(new DateTime(2016, 12, 11, 9, 35, 0));
                p2.Coming(new DateTime(2016, 12, 11, 12, 15, 0));
                p3.Coming(new DateTime(2016, 12, 11, 19, 0, 0));
                p1.GoOut();
                p3.GoOut();
                p2.GoOut();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Press any key for clossing . . .  ");
                Console.ReadKey();
            }
        }
    }
}
