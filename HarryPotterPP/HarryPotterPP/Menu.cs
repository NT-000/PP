using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterPP
{
    internal class Menu
    {
        public void StartMenu()
        {
            var magicShop = new MagicShop();
            var harry = new Character("Harry", "I'm a young wizard", "House of Gryffindor");
            var characterManager = new CharacterManager();
            while (true)
            {
                Console.WriteLine("1.Introduce yourself");
                Console.WriteLine("2.Cast a spell");
                Console.WriteLine("3.Buy animal");
                Console.WriteLine("4.Buy wand");
                Console.WriteLine("5.Show inventory");
                Console.WriteLine("6.Go back to regular school");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        characterManager.IntroduceYourself(harry);
                        break;
                    case 2:
                        Console.Clear();
                        characterManager.CastSpell();
                        break;
                    case 3:
                    case 4:
                        Console.Clear();
                        GoToShop(choice, harry, magicShop);
                        break;
                    case 5:
                        Console.Clear();
                        harry.InventoryInfo();
                            break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
        public void AnimalMenu(Character harry, MagicShop magicShop)
        {
            bool isRunning = true;

            while (isRunning) {
                Console.WriteLine("Which pet would you like to buy?");
                Console.WriteLine("1.Owl");
                Console.WriteLine("2.Cat");
                Console.WriteLine("3.Rat");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) { 
              
                    case 1:                    
                    case 2:
                        case 3:
                        magicShop.BuyItem(harry, choice);
                        isRunning = false;
                        break;
                }
            }
        }
        public void WandMenu(Character harry, MagicShop magicShop)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Which wand would you like to buy?");
                Console.WriteLine("1.Phoenix wand");
                Console.WriteLine("2.Troll wand");
                Console.WriteLine("3.Unicorn wand");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    case 2:
                    case 3:
                        magicShop.BuyItem(harry, choice + 3);
                        isRunning = false;
                        break;
                }
            }
        }
        public void GoToShop(int choice, Character harry, MagicShop magicShop)
        {
            if(choice == 3)
            {
                AnimalMenu(harry, magicShop);
            }
            if (choice == 4) {
                WandMenu(harry, magicShop);
            }
        }
    }

    }
