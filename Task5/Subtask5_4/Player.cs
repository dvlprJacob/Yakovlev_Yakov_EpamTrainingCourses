using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask5_4
{
    class Player
    {
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
        public void Step(string direction, int StepCount)
        {

        }
        public Player(int x, int y,int damage,int health)
        {
            IsAlive = true;
            Health = health;
            Damage = damage;
            Health = 100;
            X = x;
            Y = y;
        }
        public Player() { }
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
    }
}
