using System;
using System.Collections.Generic;
using System.Threading;

namespace PokemonOpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var wildPokemon = new List<IPokemon>();
            wildPokemon.Add(new Snorlax());
            wildPokemon.Add(new Goldeen());
            wildPokemon.Add(new Sparrow());
            wildPokemon.Add(new Rhino());

            var randomPokemon = getWildPokemon(wildPokemon);
            var magicarp = new Magicarp();

            while (!magicarp.IsUseless)
            {
                magicarp.Attack(randomPokemon);
                if (randomPokemon.Health <= 0)
                {
                    wildPokemon.Remove(randomPokemon);
                    randomPokemon = getWildPokemon(wildPokemon);
                }
                randomPokemon.Attack(magicarp);
                
                Thread.Sleep(400);
            }
        }

        private static IPokemon getWildPokemon(List<IPokemon> wildPokemon)
        {
            Random Random = new Random();
            var wildPokemonIndex = Random.Next(0, wildPokemon.Count);
            var randomPokemon = wildPokemon[wildPokemonIndex];
            Console.WriteLine($"NEW POKEMON --------------------->" + randomPokemon.Name);
            return randomPokemon;
        }
    }
}
