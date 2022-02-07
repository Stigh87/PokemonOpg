using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonOpg
{
    internal class Snorlax : IPokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public bool Alive;

        public Snorlax()
        {
            Name = "Snorlax";
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
            Console.WriteLine($"Snorlax: Loose {dmg} health and got {Health} left");
        }

        public void Slam(IPokemon pokemon)
        {
            var slamDmg = 30;
            Console.WriteLine($"Snorlax slams {pokemon.Name} for {slamDmg} dmg!");
            pokemon.LooseHealth(slamDmg);
        }

        public void Sleep(IPokemon pokemon)
        {
            var slamDmg = 0;
            Health += 50;
        }


    }
}
