using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask5_4
{
    class Monster
    {
        public string Name;
        public bool IsAlive { set; get; }
        public int Health { set; get; }
        public int Damage
        {
            get
            {
                return Damage;
            }
            set
            {
                if (value > 0 && value < 51)
                    Damage = value;
            }
        }
        public Monster() { }
        public Monster(int x, int y, int damage,string name)
        {
            IsAlive = true;
            Damage = damage;
            Health = 100;
            X = x;
            Y = y;
        }
        public bool PlayerIsStumblend(Player obj)
        {
            if (X == obj.X && Y == obj.Y)
            {
                obj.Health -= Damage;
                Health -= obj.Damage;
                return true;
            }
            return false;
        }
        public int X
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
