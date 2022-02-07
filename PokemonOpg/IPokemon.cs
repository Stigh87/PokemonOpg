using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonOpg
{
    internal interface IPokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }

        //void LooseHealth();
        void LooseHealth(int dmg);
        void Attack(IPokemon pokemon);
    }
}
