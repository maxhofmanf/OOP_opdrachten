using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Nurse
{
    public List<Pokeball> healingTray;

    public Nurse()
    {
        healingTray = new List<Pokeball>(); // Initialize healingTray
    }

    public Nurse(List<Pokeball> healingTray)
    {
        this.healingTray = healingTray;
    }

    public void GiveToHealingStation(Trainer trainer)
    {
        foreach (Pokeball pokeball in trainer.belt)
        {
            if (pokeball != null && pokeball.pokemon.status == false)
            {
                
                healingTray.Add(pokeball);
            }
        }

        HealingStation.Heal(healingTray);  
}
    }