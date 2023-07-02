using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class PokemonCenter
    {
    public static void Healing(Trainer trainer1, Trainer trainer2)
        {
        Nurse nurse = new Nurse();

        nurse.GiveToHealingStation(trainer1);
            nurse.GiveToHealingStation(trainer2);

        }


    }

