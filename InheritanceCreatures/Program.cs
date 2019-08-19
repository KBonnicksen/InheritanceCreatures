using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCreatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("Link");
            p1.Attack = 100;
            p1.Health = 20.75;
            p1.Stamina = 9.99;

            Enemy e = new Enemy("Gannon");
            e.EnemyID = 1;
            e.Defense = 100;
            e.RespawnRate = new TimeSpan(5, 30, 0);

            Creature c = new Player("Zelda");

            DisplayCreature(p1);
            DisplayCreature(c);
            DisplayCreature(e);

            Console.ReadKey();
        }

        static void DisplayCreature(Creature c)
        {
            if(c is Enemy)
            {
                Enemy currEnemy = c as Enemy;
                Console.WriteLine(currEnemy.EnemyID);
                Console.WriteLine("Enemy stats hidden");
            }
            else
            {
                Console.WriteLine(c.GetDisplayText("\n"));
            }
        }
    }
}
