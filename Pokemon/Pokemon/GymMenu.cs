using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class GymMenu
    {
        public GymMenu()
        {
            
        }

        public void Gym(PokemonTrainer _myPokemonTrainer)
        {
            bool isRunning = true;
            var waterMan = new PokemonTrainer("John", "Water pokemon trainer", 
                new List<Pokemon> { new Pokemon("Squirtle", "Water pokemon", 5, 20, 20, 10, 10, "water") });
            while (isRunning)
            {
                Console.WriteLine("1.Battle water gym leader");
                Console.WriteLine("2.Battle grass gym leader");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        _myPokemonTrainer.SelectPokemon(_myPokemonTrainer.GetTrainerList()[0]);
                        waterMan.SelectPokemon(waterMan.GetTrainerList()[0]);

                        Battle(_myPokemonTrainer, waterMan);
                        break;
                    case "2":
                        break;
                    case "3":
                        isRunning = false;
                        break;
                }
            }
        }

        public void Battle(PokemonTrainer _myTrainer, PokemonTrainer gymTrainer)
        {

            DisplayStats(_myTrainer, gymTrainer);
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Use item");
            while (_myTrainer.SelectedPokemon.Health >= 0 && gymTrainer.SelectedPokemon.Health >= 0)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        _myTrainer.SelectedPokemon.PokemonAttack(gymTrainer.SelectedPokemon);
                        break;
                    case "2":
                        Console.WriteLine("Using item");
                        break;
                }
                gymTrainer.SelectedPokemon.PokemonAttack(_myTrainer.SelectedPokemon);
            }
            if (_myTrainer.SelectedPokemon.Health <= 0)
            {
                Console.WriteLine($"{_myTrainer.Name} has lost");
            }
            else
            {
                Console.WriteLine($"{_myTrainer.Name} has won the fight");
            }
        }

        public void DisplayStats(PokemonTrainer _myTrainer, PokemonTrainer gymTrainer)
        {
            Console.WriteLine($"Name: {gymTrainer.SelectedPokemon.Name} Health: {gymTrainer.SelectedPokemon.HpBar()}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Name: {_myTrainer.SelectedPokemon.Name} Health: {_myTrainer.SelectedPokemon.HpBar()}");
        }

    }
}
