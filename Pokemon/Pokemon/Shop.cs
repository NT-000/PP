using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Shop
    {
        public List<Item> ShopInventory {  get; private set; }
        public List<Item> PossibleShopInventory { get; }

        public Shop()
        {
            PossibleShopInventory = new List<Item>
            {
                new Potion("small potion", 10, 10, 1),
                new Potion("medium potion", 20, 20, 2),
                new Potion("large potion", 30, 30, 3)
            };
            ShopInventory = GetRandomStoreItems();
        }

        public List<Item> GetRandomStoreItems()
        {
            Random rand = new Random();
            List<Item> inventory = new List<Item>();
            for(int i = 0; i < 7; i++)
            {
                inventory.Add(PossibleShopInventory[rand.Next(0, PossibleShopInventory.Count)]);
            }
            return inventory;
        }

        public void Shopping(PokemonTrainer myTrainer)
        {
            ShowStore();

        }

        public void ShowStore()
        {
            foreach (Item item in ShopInventory)
            {
                Console.WriteLine($"{item.Name}  Price: {item.Price} ");
            }
        }
    }
}
