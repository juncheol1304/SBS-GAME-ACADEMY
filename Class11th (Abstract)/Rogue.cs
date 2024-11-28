using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class11th__Abstract_
{
    internal class Rogue : Charater
    {
        public Rogue()
        {
            health = 80;
            attack = 15;
            defense = 2.5f;
        }
        public override void Skill()
        {
            Console.WriteLine("Sting");
        }
    }
}
