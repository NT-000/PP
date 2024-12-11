using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class PokemonWorld
    {   
        List<Pokemon> startPokemons = new List<Pokemon>
        {
            new Pokemon("Charmander", "Fire pokemon", 5, 20, 20, 10, 10, "fire"),
            new Pokemon("Bulbasaur", "Grass pokemon", 5, 20, 20, 10, 10, "grass"),
            new Pokemon("Squirtle", "Water pokemon", 5, 20, 20, 10, 10, "water"
            )
        };
        private int Input { get; set; }

        public PokemonWorld()
        {
            WorldMenu();
        }

        public void WorldMenu()
        {      
            bool isRunning = true;
            Console.WriteLine("Hi, what's your name?");
            var inputName = Console.ReadLine();
            var MyTrainer = new PokemonTrainer($"{inputName}", $"{inputName}, from X-Town");
            ChooseStartPokemon(MyTrainer);
            var gym = new GymMenu();

            while (isRunning)
            {
                Console.WriteLine("1.Go to the forrest");
                Console.WriteLine("2.Go to the lake");
                Console.WriteLine("3.Go to the gym");
                Console.WriteLine("4.Go to the shop");
                Input = int.Parse(Console.ReadLine());

                switch (Input)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        gym.Gym(MyTrainer);
                        break;
                    case 4:
                        Shop shop = new Shop();
                        shop.Shopping(MyTrainer);
                        break;
                    case 5:
                        MyTrainer.ShowTrainerPokemons();
                        break;

                }
            }
        }


        public void ChooseStartPokemon(PokemonTrainer _trainer)
        {
            int counter = 1;
            Console.WriteLine("Choose your pokemon:");
            foreach (var pokemon in startPokemons)
            {
                Console.WriteLine($"{counter}.{pokemon.Name}");
                counter++;
            }
            var input = int.Parse(Console.ReadLine());
            var chosenPokemon = startPokemons[input - 1];
            Console.WriteLine($"{_trainer.Name} chose {chosenPokemon.Name}");
            _trainer.GetTrainerList().Add(chosenPokemon);
        }

    }
}
