using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Яковлев_Яков_Task1
{
    class Vector
    {
        private double x;
        private double y;

        public Vector()
        {
            x = 0;
            y = 0;
        }
        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void SetX(double x) { this.x = x; }
        public void SetY(double y) { this.y = y; }
        public void Set(double x, double y)
        {
            SetX(x);
            SetY(y);
        }
        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }
       public bool aPlace()
        {
            if (GetX() * GetX() + GetY() * GetY() <= 1)
                return true;
            return false;
        }
        public bool bPlace()
        {
            if (((x * x + y * y) <= 1) & ((x * x + y * y) >= 0.5))
                return true;
            return false;
        }
        public bool vPlace()
        {
            if ((Math.Abs(x) - 1 <= 0) & (Math.Abs(y) - 1 <= 0))
                return true;
            return false;
        }
        public bool gPlace()
        {
            if (Math.Abs(x) + Math.Abs(y) <= 1)
                return true;
            return false;
        }
    }
    
    class Program
        {
        
        static void Main(string[] args)
            {
                Console.WriteLine("Даны заштрихованные области.Необходимо определить принадлежность введенной точки выбранной области.");
                string buf="";
                Vector a = new Vector();
                while(buf!="Выход")
                {
                    Console.WriteLine("     Меню     \n 1 - Ввести точку.\n 2 - Выбрать область.\n 3 - Выход.");
                    Console.Write("Введите команду _ _ _ ");
                    buf = Console.ReadLine();
                    switch(buf)
                    {
                        case "1":
                            
                                Console.Write("x = ");
                                double x = Convert.ToDouble(Console.ReadLine());
                                Console.Write("y = ");
                                double y = Convert.ToDouble(Console.ReadLine());
                                a.Set(x,y);
                            break;

                        case "2":
                            Console.Write("Области: а , б , в , г \nВведите область или Выход _ _ _ ");
                            string area = Console.ReadLine(); ;
                        switch (area)
                        {
                            case "а": if (a.aPlace())
                                    Console.WriteLine("Точка[{0};{1}] принадлежит фигуре {2} .",a.GetX(),a.GetY(),area) ;
                            else
                                    Console.WriteLine("Точка[{0};{1}] не принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                continue;
                            case "б": if (a.bPlace())
                                    Console.WriteLine("Точка[{0};{1}] принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                else
                                    Console.WriteLine("Точка[{0};{1}] не принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                continue;
                            case "в":
                                if (a.vPlace())
                                    Console.WriteLine("Точка[{0};{1}] принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                else
                                    Console.WriteLine("Точка[{0};{1}] не принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                continue;
                            case "г":
                                if (a.gPlace())
                                    Console.WriteLine("Точка[{0};{1}] принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                else
                                    Console.WriteLine("Точка[{0};{1}] не принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                continue;
                            case "Выход": break;
                            default: Console.WriteLine("Некорректная команда") ;
                                continue;
                        }
                            break;
                    case "3": return;
                    default:continue;
                    }

                }

            }
        }
    }

