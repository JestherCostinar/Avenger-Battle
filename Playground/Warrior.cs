using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Warrior
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double AttkMax { get; set; } 
        public double BlockMax { get; set; }

        Random rand = new Random();

        public Warrior(string name = "Warrior", double health = 0, double attackDamage = 0, double block = 0) { 
            Name = name;
            Health = health;
            AttkMax = attackDamage;
            BlockMax = block; 
        }

        public double Attack()
        {
            return rand.Next(1, (int) AttkMax);
        }

        public virtual double Block()
        {
            return rand.Next(1, (int) BlockMax);
        }
    }
}
