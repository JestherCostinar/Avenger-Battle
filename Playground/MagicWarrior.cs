using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class MagicWarrior : Warrior
    {
        int teleportChance = 0;
        CanTeleport teleportType = new CanTeleport();
        
        public MagicWarrior(string name = "Warrior", double health = 0, double attackMax = 0,
           double blockMax = 0,
           int teleportChance = 0) : base (name, health, attackMax, blockMax)
        {
            this.teleportChance = teleportChance;
        }

        public override double Block()
        {
            Random random = new Random();
            int ranDodge = random.Next(1, 100);

            if (ranDodge < this.teleportChance)
            {
                Console.WriteLine($"{Name} {teleportType.Teleport()}");
                return 0;
            } else {
                return base.Block();
            }
        }
    }
}
