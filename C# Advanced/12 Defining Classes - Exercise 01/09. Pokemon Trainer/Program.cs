using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Trainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {          

            Dictionary<string, Trainer> trainerList = new Dictionary<string, Trainer>();

            string command;
            int numberOfBadges = 0;

            while ((command = Console.ReadLine()) != "Tournament")
            {
                //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"

                string[] cmdArguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = cmdArguments[0];
                string pokemonName = cmdArguments[1];
                string pokemonElement = cmdArguments[2];
                int pokemonHealth = int.Parse(cmdArguments[3]);

                if (!trainerList.ContainsKey(trainerName))
                {
                    Trainer newTrainer = new Trainer(pokemonName, numberOfBadges);
                    trainerList[trainerName] = newTrainer;
                   
                }

                Pokemon crrPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                Trainer trainer = trainerList[trainerName];

                trainer.ListOfPokemons.Add(crrPokemon);
                
            }

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdNexArguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //•	"Fire"
                //•	"Water"
                //•	"Electricity

                if (command == "Fire" || command == "Water" || command == "Electricity")
                {
                    foreach (var trainer in trainerList)
                    {
                        int crrNumberOfPokemons = trainer.Value.ListOfPokemons.Where(x => x.Element == command).Count();

                        if (crrNumberOfPokemons >= 1)
                        {
                            trainer.Value.NumberOfBadges++;
                            continue;
                        }
                       
                        foreach (var pokemon in trainer.Value.ListOfPokemons)
                        {
                            pokemon.Health -= 10;
                        }

                        trainer.Value.ListOfPokemons.RemoveAll(x => x.Health <= 0);

                    }
                }
            }

            foreach (var trainer in trainerList.OrderByDescending(x => x.Value.NumberOfBadges))
            {
                //"{trainerName} {badges} {numberOfPokemon}

                Console.WriteLine($"{trainer.Key} {trainer.Value.NumberOfBadges} {trainer.Value.ListOfPokemons.Count}");


            }
            

        }
    }
}
