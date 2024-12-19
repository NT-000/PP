using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterPP
{
    internal class CharacterManager
    {
        public CharacterManager() { }

        public void IntroduceYourself(Character harry)
        {
            Console.WriteLine($"My name is {harry.Name}, {harry.Description} and I'm from the {harry.House}\n");
        }
        public void CastSpell()
        {
            Console.WriteLine("Utter your words and cast a spell");
            var input = Console.ReadLine().ToLower();
            Console.Clear();
            Thread.Sleep(1000);
            if (input == "vingardium leviosa")
            {
                Console.WriteLine("Vingardium leviosa!");
                Console.WriteLine("får en fjær til å fly");
            }
            if(input == "hokus pokus")
            {
                Console.WriteLine("Hokus pokus!");

                Console.WriteLine("fyrer av fyrverkerie");
            }
            else
            {
                Console.WriteLine("Invalid value,try again !!");
            }
        }
        public void SelectWand()
        {

        }
    }
}
