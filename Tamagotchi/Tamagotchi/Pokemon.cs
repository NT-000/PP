using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    internal class Pokemon
    {
        private List<Pokemon> pokemon = new List<Pokemon>();
        public static int dayCounter = 1;
        private string Name { get; set; }
        private int Age { get; set; }
        private int Fun { get; set; }
        private int Hunger { get; set; }
        private int Bladder { get; set; }
        private int Happiness { get; set; }

        public Pokemon(string name, int age)
        {
            Name = name;
            Age = age;
            Fun = 5;
            Hunger = 5;
            Bladder = 5;
            Happiness = 5;
        }

        public void plusAge()
        {
            Age++;
        }

        public void AddPokemon()
        {
            Console.WriteLine("Pick a name");
            var inputName = Console.ReadLine();
            Console.WriteLine("Pick a age");
            var inputAge = int.Parse(Console.ReadLine());
            Pokemon poke = new Pokemon(inputName, inputAge);
            pokemon.Add(poke);
            Console.WriteLine($"{Name} just hatched...");
            Thread.Sleep(1500);
        }
        public void RandomEvent()
        {   
            Console.Clear();
            Random num = new Random();
            int number = num.Next(1, 10);
            int number2 = num.Next(1, 10);
            if (number == dayCounter)
            {
                PokemonLucky();
            }
            else if (number2 == dayCounter)
            {
                PokemonUnlucky();
            }
        }

        public void PokemonLucky()
        {
            Happiness += 5;
            Hunger += 3;
            Happiness = Math.Min(Happiness, 10);
            Hunger = Math.Min(Hunger, 10);
            Console.WriteLine($"{Name} found a rare candy!");
        }
        public void PokemonUnlucky()
        {
            Happiness -= 3;
            Hunger -= 1;
            Happiness = Math.Min(Happiness, 10);
            Hunger = Math.Min(Hunger, 10);
            Console.WriteLine($"{Name} slipped and fell!");
        }

        public int GetAge()
        {
            return Age;
        }
        public int GetDayCounter()
        {
            return dayCounter;
        }

        public string GetName()
        {
            return Name;
        }
        public void PassTime()
        {
            Hunger -= 3;
            Bladder -= 2;
            Happiness += 3;
            Hunger = Math.Min(Hunger, 10);
            Bladder = Math.Min(Bladder, 10);
            Happiness = Math.Min(Happiness, 10);
            dayCounter++;
            plusAge();
            Console.WriteLine("A day has passed...");
            Thread.Sleep(1000);
        }
        public void DisplayInfo()
        {
            Console.Clear();
            Console.WriteLine($"{Name} stats");
            HungerBar();
            FunBar();
            BladderBar();
            HappinessBar();
        }
        public void Feed()
        {
            Hunger += 3;
            Bladder -= 1;
            Happiness += 2;
            Hunger = Math.Min(Hunger, 10);
            Bladder = Math.Min(Bladder, 10);
            Happiness = Math.Min(Happiness, 10);
        }

        public void HungerBar()
        {
            var hungerBar = "";
            for (int i = 0; i < Hunger; i++)
            {
                hungerBar += "\u258c"; ;
            }

            if (Hunger < 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Name} is dying...");
            }
            else if (Hunger < 6)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{Name} is okay...");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{Name} is happy...");
            }

            Console.WriteLine($"Hunger:{hungerBar} {Hunger}");
            Console.ResetColor();
        }
        public void FunBar()
        {
            var funBar = "";
            for (int i = 0; i < Fun; i++)
            {
                funBar += "\u258c"; ;
            }

            if (Fun < 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Name} is dying...");
            }
            else if (Fun < 6)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{Name} is okay...");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{Name} is happy...");
            }
            Console.WriteLine($"Fun:{funBar} {Fun}");
            Console.ResetColor();

        }
        public void BladderBar()
        {
            var bladderBar = "";
            for (int i = 0; i < Hunger; i++)
            {
                bladderBar += "\u258c";
            }

            if (Bladder < 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Name} is dying...");
            }
            else if (Bladder < 6)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{Name} is okay...");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{Name} is happy...");
            }
            Console.WriteLine($"Bladder:{bladderBar} {Bladder}");
            Console.ResetColor();
        }
        public void HappinessBar()
        {
            var happinessBar = "";
            for (int i = 0; i < Hunger; i++)
            {
                happinessBar += "\u258c"; ;
            }

            if (Happiness < 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Name} is dying...");
            }
            else if (Happiness < 6)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{Name} is okay...");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{Name} is happy...");
            }
            Console.WriteLine($"Happiness:{happinessBar} {Happiness}");
            Console.ResetColor();
        }
        public void Play()
        {
            Bladder -= 1;
            Fun += 2;
            Hunger -= 1;
            Happiness += 2;
            Hunger = Math.Min(Hunger, 10);
            Bladder = Math.Min(Bladder, 10);
            Happiness = Math.Min(Happiness, 10);
            Fun = Math.Min(Fun, 10);
        }
        public void Pee()
        {
            Bladder += 10;
            Happiness += 2;
            Bladder = Math.Min(Bladder, 10);
            Happiness = Math.Min(Happiness, 10);
        }
    }
}
