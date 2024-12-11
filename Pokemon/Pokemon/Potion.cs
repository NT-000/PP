using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Potion : Item
    {
        public int Strength { get; set; }
        public int Size { get; set; }

        public Potion(string name, int price, int strength, int size)
        {
            Name = name;
            Price = price;
            Strength = strength;
            Size = size;
        }
    }

   
}
