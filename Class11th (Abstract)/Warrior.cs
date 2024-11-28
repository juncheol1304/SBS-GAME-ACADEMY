using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class11th__Abstract_
{
    internal class Warrior : Charater
    {
        public Warrior()
        {
            health = 100;
            attack = 5;
            defense = 5;
        }
        public override void Skill()
        {
            Console.WriteLine("Slash Sword");
        }
    }
}
