using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask5_4
{
    class Bonus
    {
        protected string Name;
        public bool IsAlive { set; get; }
        public int HealthApp
        {
            get
            {
                return HealthApp;
            }
            set
            {
                if (value > 0 && value < 51)
                    HealthApp = value;
            }
        }
        public Bonus(int x, int y, int health_app,string Name)
        {
            IsAlive = true;
            HealthApp = health_app;
            X = x;
            Y = y;
        }
        public bool PlayerIsStumblend(Player obj)
        {
            if (X == obj.X && Y == obj.Y)
            {
                obj.Health += HealthApp;
                HealthApp = 0;
                return true;
            }
            return false;
        }
        public Bonus() { }
        public int X//todo см. предыдущие комментарии!
        {
            get
            {
                return X;
            }
            set
            {
                if (X > 0)
                    X = value;

            }
        }
        public int Y
        {
            get
            {
                return Y;
            }
            set
            {
                if (Y > 0)
                    Y = value;

            }
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
