using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonOpg
{
    internal class Goldeen : IPokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public bool Alive;

        public Goldeen()
        {
            Name = "Goldeen";
            Health = 200;
            Alive = Health < 0 ? true : false;
        }

        //public void LooseHealth()
        //{
        //    Console.WriteLine("Snorlax: Loose health uten parameter");
        //}
        public void Attack(IPokemon pokemon)
        {
            Slam(pokemon);
        }


        public void LooseHealth(int dmg)
        {
            Health -= dmg;
            Console.WriteLine($"Goldeen: Loose {dmg} health and got {Health} left");
        }

        public void Slam(IPokemon pokemon)
        {
            var slamDmg = 30;
            Console.WriteLine($"Goldeen slams {pokemon.Name} for {slamDmg} dmg!");
            pokemon.LooseHealth(slamDmg);
        }

    }
}
