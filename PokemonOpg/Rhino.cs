using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonOpg
{
    internal class Rhino : IPokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public bool Alive;

        public Rhino()
        {
            Name = "Rhino";
            Health = 200;
            Alive = Health < 0 ? true : false;
        }

        //public void LooseHealth()
        //{
        //    Console.WriteLine("Snorlax: Loose health uten parameter");
        //}
        public void Attack(IPokemon pokemon)
        {
            poke(pokemon);
        }

        public void LooseHealth(int dmg)
        {
            Health -= dmg;
            Console.WriteLine($"Rhino: Loose {dmg} health and got {Health} left");
        }

        public void poke(IPokemon pokemon)
        {
            var slamDmg = 60;
            Console.WriteLine($"Rhino poke {pokemon.Name} for {slamDmg} dmg!");
            pokemon.LooseHealth(slamDmg);
        }

    }
}
