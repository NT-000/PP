using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Pokemon
    {   
        public string Name { get; private set; }
        public string Description { get; private set; }
        
        public int Level { get; private set; }
        public int Health { get; private set; }

        public int MaxHp { get; private set; }

        public int Attack { get; private set; }

        public int Defence { get; private set; }

        public string Type { get; private set; }

        public Pokemon(string name, string description, int level, int health, int maxHp, int attack, int defence, string type)
        {
            Name = name;
            Description = description;
            Level = level;
            Health = health;
            MaxHp = maxHp;
            Attack = attack;
            Defence = defence;
            Type = type;
        }

        public string HpBar()
        {
            var hpBar = "";
            int hpBlocks = Health * 10 / MaxHp;
            for (var i = 0; i < 10; i++)
            {
                if (i < hpBlocks)
                {
                    hpBar += "\u258c";
                }
                else
                {
                    hpBar += "";
                }
            }

            if (Health < 0.1 * MaxHp)
            {
                Console.ForegroundColor = ConsoleColor.Red;

            } 
            else if (Health < 0.5 * MaxHp)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            return hpBar;
        }

        public void PokemonAttack(Pokemon target)
        {
            target.Health = target.Health - Attack;
            Console.WriteLine($"{Name} hit {target.Name} for {Attack} damage.");
        }

    }
}
