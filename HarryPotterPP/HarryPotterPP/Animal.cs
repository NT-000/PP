using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterPP
{
    internal class Animal : IItem
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }
        public Animal(string name, int id)
        {
            Name = name;
            Type = "animal";
            Id = id;
        }
    }
}
