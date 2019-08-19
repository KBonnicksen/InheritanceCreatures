using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCreatures
{
    class Creature
    {
        public Creature(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public double Health { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        /// <summary>
        /// The level of speed that the character has at any given moment
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// The ethnic race of the character
        /// </summary>
        public string Race { get; set; }

        /// <summary>
        /// Returns a basic string representation of the creature
        /// </summary>
        /// <param name="sep">he separator to place between each piece of data</param>
        /// <returns></returns>
        public virtual string GetDisplayText(string sep)
        {
            //Virtual says that you CAN override this method in subclasses
            return $"{Name}{sep}{Health}{sep}{Race}";
        }
    }

    class Player : Creature
    {
        public Player(string playerName) : base(playerName)
        {
            //This cunstructor setup is the same thing as calling 
            //the super keyword in java
        }

        /// <summary>
        /// Used when the player running or performing physical actions.
        /// </summary>
        public double Stamina { get; set; }

        /// <summary>
        /// These are the magic points for the character. 
        /// Spells use mana to execute.
        /// </summary>
        public double Mana { get; set; }

        public override string GetDisplayText(string sep)
        {
            return "Player" + sep + base.GetDisplayText(sep) + sep + Stamina;
        }
    }

    class Enemy : Creature
    {
        public Enemy(string enemyName) : base(enemyName)
        {

        }
        public int EnemyID { get; set; }

        /// <summary>
        /// How long the enemy takes to respawn after they are defeated.
        /// If the enemy dodes not have a respawn rate, once they are defeated,
        /// they never respawn.
        /// </summary>
        public TimeSpan? RespawnRate { get; set; }

        public int ExperienceDropRate { get; set; }

        public List<Item> ItemDrops { get; set; }
    }
}
