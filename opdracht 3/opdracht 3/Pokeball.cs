using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3
{
    internal class Pokeball
    {
        
        public Charmander charmander;

        public Pokeball()
        {
            charmander = new Charmander("sparky", "water", "fire");
        }
        public void OpenBall()
        {
            charmander.battleCry();

            
        }
    }
}
