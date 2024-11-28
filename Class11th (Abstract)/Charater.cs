using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class11th__Abstract_
{
    internal abstract class Charater
    {
        protected int health;
        protected int attack;
        protected float defense;

        public void Stats()
        {
            Console.WriteLine("health : " + health);
            Console.WriteLine("defense : " + defense);
            Console.WriteLine("attack : " + attack);
        }
        public abstract void Skill();
    }
}
