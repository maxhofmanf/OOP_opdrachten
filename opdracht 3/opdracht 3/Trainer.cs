using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3
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
        public void ThrowBall(int number, Trainer trainer)
        {
            Console.WriteLine(trainer.Name + " sends out " + belt[number].charmander?.name);
            belt[number].OpenBall();

        }

    }
}
