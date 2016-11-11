using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Яковлев_Яков_Task1
{

    public class Point
    {
        public double x;
        public double y;
        public Point(double x, double y)
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
            if (GetX() * GetX() + GetY() * GetY() <= 1) //todo лучше было бы написать return GetX() * GetX() + GetY() * GetY() <= 1 и обойтись одной строкой вместо 3-х
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
    public class Treangle
    {
        public Point A;
        public Point B;
        public Point C;
        public double Area(Point A,Point B,Point C)
        {
            double a = Math.Sqrt((A.GetX() - B.GetX()) * (A.GetX() - B.GetX()) + (A.GetY() - B.GetY()) * (A.GetY() - B.GetY()));
            double b = Math.Sqrt((B.GetX() - C.GetX()) * (B.GetX() - C.GetX()) + (B.GetY() - C.GetY()) * (B.GetY() - C.GetY()));
            double c = Math.Sqrt((C.GetX() - A.GetX()) * (C.GetX() - A.GetX()) + (C.GetY() - A.GetY()) * (C.GetY() - A.GetY()));
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public Treangle(Point a,Point b,Point c)
        {
            A = new Point(a.x, a.y);
            B=new Point(b.x, b.y);
            C=new Point(c.x, c.y);
        }
        public bool PointInTriangle(Point d)
        {
            double t = 0.0000000001;
            double s = Area(A,B,C);
            double s1 = Area(A, B, d);
            double s2 = Area(A, d, C);
            double s3 = Area(d, B, C);
            if (Math.Abs((s1 + s2 + s3) - s) <t)
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
            Point a = new Point(0, 0); ;
                while(buf!="Выход")
                {
                    Console.WriteLine("     Меню     \n 1 - Ввести точку.\n 2 - Выбрать область.\n 3 - Выход.");
                    Console.Write("Введите команду _ _ _ ");
                    buf = Console.ReadLine();
                switch (buf)//todo съехало, за этим тоже желательно следить перед заливкой в репозиторий.
                    {
                        case "1":
                        {
                            Console.Write("x = ");
                            double x = Convert.ToDouble(Console.ReadLine());
                            Console.Write("y = ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            a.x = x;
                            a.y = y;
                            break;
                        }
                        //todo лишний пробел
                        case "2":
                            Console.Write("Области: а , б , в , г , д , е , и , ж , з , к\nВведите область или Выход _ _ _ ");
                            string area = Console.ReadLine(); ;
                        switch (area)
                        {
                            case "а":
                                if (a.aPlace())
                                    Console.WriteLine("Точка[{0};{1}] принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);//todo две почти одинаковые строки можно вынести в отдельную строку и заполнять в зависимости от параметра. Исправить везде в этом файле.
                                else
                                    Console.WriteLine("Точка[{0};{1}] не принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);//todo почти одинаковая со 125й строкой. Подумать, как написать 124-127 одной строкой. Исправить везде в этом файле (где это возможно сделать).
                                continue;
                            case "б":
                                if (a.bPlace())
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
                            case "д":
                                {
                                    Point p1 = new Point(0, 1);
                                    Point p2 = new Point(0.5, 0);
                                    Point p3 = new Point(-0.5, 0);
                                    Point p4 = new Point(0, -1);
                                    Treangle t1 = new Treangle(p1, p2, p3);
                                    Treangle t2 = new Treangle(p3, p2, p4);
                                    if (t1.PointInTriangle(a) || t1.PointInTriangle(a))
                                        Console.WriteLine("Точка[{0};{1}] принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                    else
                                        Console.WriteLine("Точка[{0};{1}] не принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                    continue;
                                }
                            case "е":
                                {
                                    if (a.x > 0)
                                        if (a.aPlace())
                                            Console.WriteLine("Точка[{0};{1}] принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                        else
                                            Console.WriteLine("Точка[{0};{1}] не принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                    else
                                    {
                                        Point p1 = new Point(0, 1);
                                        Point p2 = new Point(0, 0);
                                        Point p3 = new Point(-2, 0);
                                        Point p4 = new Point(0, -1);
                                        Treangle t1 = new Treangle(p1, p2, p3);
                                        Treangle t2 = new Treangle(p3, p2, p4);
                                        if (t1.PointInTriangle(a) || t1.PointInTriangle(a))
                                            Console.WriteLine("Точка[{0};{1}] принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                        else
                                            Console.WriteLine("Точка[{0};{1}] не принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                    }
                                    continue;
                                }
                            case "з":
                                {
                                    if (a.y > 0)
                                    {
                                        if (a.x >= 0)
                                        {
                                            Point p1 = new Point(0, 0);
                                            Point p2 = new Point(1, 0);
                                            Point p3 = new Point(1, 1);
                                            Treangle t1 = new Treangle(p1, p2, p3);
                                            if (t1.PointInTriangle(a))
                                                Console.WriteLine("Точка[{0};{1}] принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                            else
                                                Console.WriteLine("Точка[{0};{1}] не принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                            break;
                                        }
                                        if (a.x < 0) //todo почему без else? после того, как проверится условие на 187 строке начнется проверка условия на 199. Излишнее поведение. Исправить везде в этом файле.
                                        {
                                            Point p1 = new Point(0, 0);
                                            Point p2 = new Point(-1, 0);
                                            Point p3 = new Point(-1, -1);
                                            Treangle t1 = new Treangle(p1, p2, p3);
                                            if (t1.PointInTriangle(a))
                                                Console.WriteLine("Точка[{0};{1}] принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                            else
                                                Console.WriteLine("Точка[{0};{1}] не принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                            break;
                                        }
                                        if ((a.x <= 1 && a.x >= -1) && (a.y <= 0 && a.y >= -2))
                                        {
                                            Console.WriteLine("Точка[{0};{1}] принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                            break;
                                        }
                                        Console.WriteLine("Точка[{0};{1}] не принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                    }
                                    continue;
                                }
                            case "к":
                                {
                                    if (a.y < 1)
                                    {
                                        Point p1 = new Point(0, 0);
                                        Point p2 = new Point(1, 1);
                                        Point p3 = new Point(-1, 1);
                                        Treangle t1 = new Treangle(p1, p2, p3);
                                        if (t1.PointInTriangle(a))
                                            Console.WriteLine("Точка[{0};{1}] принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                        else
                                            Console.WriteLine("Точка[{0};{1}] не принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                        break;
                                    }
                                    if (a.y >= 1)
                                    {
                                        Console.WriteLine("Точка[{0};{1}] принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                        break;
                                    }
                                    Console.WriteLine("Точка[{0};{1}] не принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                    break;
                                }
                            case "ж":
                                {
                                    Point p1 = new Point(0, 2);
                                    Point p2 = new Point(1.5, -1);
                                    Point p3 = new Point(-1.5, -1);
                                    Treangle t1 = new Treangle(p1, p2, p3);
                                    if (t1.PointInTriangle(a))
                                        Console.WriteLine("Точка[{0};{1}] принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                    else
                                        Console.WriteLine("Точка[{0};{1}] не принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                    break;
                                }
                            case "и":
                                {
                                    if (a.y >= 0)
                                    {
                                        Point p1 = new Point(-1, 1);
                                        Point p2 = new Point(0, 0);
                                        Point p3 = new Point(-1.5, 0);
                                        Treangle t1 = new Treangle(p1, p2, p3);
                                        if (t1.PointInTriangle(a))
                                            Console.WriteLine("Точка[{0};{1}] принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                        else
                                            Console.WriteLine("Точка[{0};{1}] не принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                        break;
                                    }
                                    else
                                    {
                                        Point p1 = new Point(1, 0);
                                        Point p2 = new Point(-2, -1);
                                        Point p3 = new Point(-1.5, 0);
                                        Treangle t1 = new Treangle(p1, p2, p3);
                                        if (t1.PointInTriangle(a))
                                            Console.WriteLine("Точка[{0};{1}] принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                        else
                                            Console.WriteLine("Точка[{0};{1}] не принадлежит фигуре {2} .", a.GetX(), a.GetY(), area);
                                        break;
                                    }
                                }
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

