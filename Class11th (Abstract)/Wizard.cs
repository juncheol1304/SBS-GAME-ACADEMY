using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class11th__Abstract_
{
  
    internal class Wizard : Charater
    {
        public Wizard()
        {
            health = 75;
            attack = 10;
            defense = 1;
        }

        public override void Skill()
        {
            Console.WriteLine("Meteor");
        }
    }
}
