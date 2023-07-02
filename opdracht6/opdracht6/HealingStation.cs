using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class HealingStation
{
    public static void Heal(List<Pokeball> healingTray)
    {
        int i = 1;

        foreach (Pokeball pokeball in healingTray)
        {


            //if (pokeball.pokemon.status == false)
            //{
                if ( i <= 4)
                {
                    Console.WriteLine("");
                    pokeball.pokemon.status = true;
                    Console.WriteLine(pokeball.pokemon.name + " has been healed");
                    Console.WriteLine("");
                     i ++;
                } else
                {
                    i = 1;
                Console.WriteLine("");
                Console.WriteLine("new tray has been put in the healing station");
                    pokeball.pokemon.status = true;
                    Console.WriteLine(pokeball.pokemon.name + " has been healed");
                    
                }
            //}
        }
    }
}