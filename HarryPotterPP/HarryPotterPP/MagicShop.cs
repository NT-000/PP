using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterPP
{
    internal class MagicShop
    {   
        public List<IItem> Inventory { get; private set; }
        public MagicShop() {

            Inventory =
                [
                new Animal("John", 1),
                new Animal("Mjau", 2),
                new Animal("Fatty Ratty", 3),
                new Wand("Phoenix wand", 4),
                new Wand("Troll wand", 5),
                new Wand("Unicorn wand", 6),
                ];
        }
        public void BuyItem(Character harry, int choice)
        {
            if(choice <= 3)
            { 
                var animal = Inventory.Find(animal => animal.Id == choice);
                harry.Items.Add(animal);
                Console.WriteLine($"{animal.Name} just added to your inventory!");
            }
            if (choice >= 4) { 
                var wand = Inventory.Find(wand => wand.Id == choice);
                harry.Items.Add(wand);
                Console.WriteLine($"{wand.Name} just added to your inventory");
                var selectedWand = harry.GetSelectedWand();
                selectedWand = harry.SetSelectedWand(wand);
                Console.WriteLine($"You just equipped {selectedWand.Name}");
            }
        }
    }
}
