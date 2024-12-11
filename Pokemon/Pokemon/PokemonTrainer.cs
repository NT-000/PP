using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class PokemonTrainer
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        List<Pokemon> _trainerpokemons = new List<Pokemon>();

        List<Item> _Items = new List<Item>();

        public Pokemon SelectedPokemon { get; private set; }

        public PokemonTrainer(string name, string description)
        {
            Name = name;
            Description = description;
            SelectedPokemon = null;
            _trainerpokemons = new List<Pokemon>();
            _Items = new List<Item>();

        }

        public PokemonTrainer(string name, string description, List<Pokemon> gymTrainerpokemons)
        {
            Name = name;
            Description = description;
            SelectedPokemon = null;
            _trainerpokemons = gymTrainerpokemons;
            _Items = new List<Item>();

        }

        public List<Pokemon> GetTrainerList()
        {
            return _trainerpokemons;
        }
        public Pokemon GetSelectedPokemon()
        {
            return SelectedPokemon;
        }
        public void ShowTrainerPokemons()
        {
            Console.WriteLine("Your pokemon:");
            foreach (var pokemon in _trainerpokemons)
            {
                Console.WriteLine($"Name:{pokemon.Name}");
            }
        }

        public void SelectPokemon(Pokemon newSelect)
        {
            SelectedPokemon = newSelect;
        }

    }
}
