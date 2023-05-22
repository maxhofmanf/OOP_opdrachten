using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2.src
{
    internal class Pokeball
    {
        public Charmander? charmander;


        public void addPokemon()
        {
            Charmander charmander = new Charmander("sparky", "water", "fire");
            this.charmander = charmander;
        }
        public void OpenBall()
        {
            if (charmander != null)
            {
                charmander.battleCry();
            }
        }
    }
}
