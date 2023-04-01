using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Battle
    {
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true) { 
                if (GetAttackResult(warrior1, warrior2) == "Game Over") 
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        // Get Attack Result
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warrionAAttackAmount = warriorA.Attack();
            double warrionBBlockAmount = warriorB.Block();

            double damageOfAttack = warrionAAttackAmount = warrionBBlockAmount;

            if (damageOfAttack > 0)
            {
                warriorB.Health = warriorB.Health - damageOfAttack;
            } else
            {
                damageOfAttack = 0;
            }
         

            Console.WriteLine($"{warriorA.Name} attacks {warriorB.Name} and Deals {damageOfAttack} Damage");
            Console.WriteLine($"{warriorB.Name} has {warriorB.Health} Health\n");

            if (warriorB.Health <= 0) {
                Console.WriteLine($"{warriorB.Name} has Died {warriorA.Name} Win");

                return "Game Over";
            }

            else
            {
                return "Fight Again";
            }
        }
    }
}
