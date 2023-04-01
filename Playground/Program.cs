using System;

namespace Playground
{
    public class Program
    {

        static void Main(string[] args)
        {
           Warrior thor = new Warrior("Thor", 100, 26, 10);
           Warrior loki = new Warrior("Loki", 100, 26, 10);

           Battle.StartFight(thor, loki);
        }
    }
}