using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterPP
{
    internal class Character
    {
        public string Name { get; private set;}
        public string Description { get; private set;}
        public string House { get; private set;}

        public List<IItem> Items { get; private set; }

        public IItem SelectedWand { get; private set; }

        public Character(string name, string description, string house)
        {
            Name = name;
            Description = description;
            House = house;
            Items = new List<IItem>();
            SelectedWand = null;

        }

        public IItem GetSelectedWand()
        {
            return SelectedWand;
        }
        public IItem SetSelectedWand(IItem wand)
        {
           return SelectedWand = wand;
        }

        public void InventoryInfo()
        {
            Console.WriteLine("Følgende ting i min inventory :"); 
                if (Items.Count == 0) 
            {
                Console.WriteLine("Jeg har ingenting");

            }
            else
            {
                foreach(var item in Items)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }

    }
}
