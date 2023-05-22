using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2.src
{
    internal class Trainer
    {
        
        public string? Name;
        public List<Pokeball> belt;

        public Trainer(string? Name)
        {
            this.Name = Name;
            belt = new List<Pokeball>();

            for (int i = 0; i < 6; i++)
            {
                belt.Add(new Pokeball());
            }
        }
        public void ThrowBall(int number)
        {
            belt[number].OpenBall();

        }
        
    }
}
