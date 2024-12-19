using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterPP
{
    internal class Wand : IItem
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }

        public Wand(string name, int id)
        {
            Name = name;
            Type = "wand";
            Id = id;
        }
    }
}
