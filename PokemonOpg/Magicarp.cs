using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonOpg
{
    internal class Magicarp : IPokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public bool IsUseless { get; private set; }


        public Magicarp()
        {
            Name = "Magicarp";
            IsUseless = false;
            Health = 1000;
        }

        public void Attack(IPokemon pokemon)
        {
            Splash(pokemon);
        }
        public void Splash(IPokemon pokemon)
        {
            var splashDmg = 10;
            Console.WriteLine("Magicarp splash " + pokemon.Name + "for " + splashDmg + " dmg!");
            pokemon.LooseHealth(splashDmg);
        }

        //public void LooseHealth()
        //{
        //    Console.WriteLine("Magicarp Loose health uten parameter");
        //}

        public void LooseHealth(int dmg)
        {
            Health -= dmg;
            if (Health <= 0) IsUseless = true;
            Console.WriteLine($"Magicarp Loose {dmg} health! and got {Health} left");
        }
    }
}
