using game;
using System.Reflection;
using System.Text;

class Battle
{
    public static string? previous_winner;
    public static void Fight(Trainer trainer1, Trainer trainer2, int[] scoreboard)
    { 
        int allPokemon_1 = trainer1.belt.Count;
        int allPokemon_2 = trainer2.belt.Count;
        string? winner = "";
        int pokemon_trainer1 = 0;
        int pokemon_trainer2 = 0;

        bool defeated_pokemon1 = false;
        bool defeated_pokemon2 = false;

        //Console.WriteLine(allPokemon_1 + " " + allPokemon_2);
        if (trainer1.belt[pokemon_trainer1].pokemon?.weakness == trainer2.belt[pokemon_trainer2].pokemon?.strength)
        {
            winner = trainer2.Name;
            previous_winner = trainer2.Name;
            scoreboard[0] += 1;
            defeated_pokemon1 = true;
        }
        else if (trainer1.belt[pokemon_trainer1].pokemon?.strength == trainer2.belt[pokemon_trainer2].pokemon?.weakness)
        {
            winner = trainer1.Name;
            previous_winner = trainer1.Name;
            scoreboard[1] += 1;
            defeated_pokemon2 = true;
        }
        else
        {
            winner = "nobody wins";
        }

        trainer1.ThrowBall(pokemon_trainer1, trainer1);
        trainer2.ThrowBall(pokemon_trainer2, trainer2);
        Console.Write("");
        trainer1.belt[pokemon_trainer1].pokemon?.battleCry();
        Console.WriteLine("");


        trainer2.belt[pokemon_trainer2].pokemon?.battleCry();
        Console.WriteLine("");

        Console.WriteLine(winner + " wins");
        Console.WriteLine("");

        if (winner == "nobody wins")
        {
            if (previous_winner == null)
            {
                Console.WriteLine(trainer1 + " calls back " + trainer1.belt[pokemon_trainer1].pokemon?.name);
                trainer1.belt[pokemon_trainer1].closes();

                Console.WriteLine(trainer2 + " calls back " + trainer2.belt[pokemon_trainer2].pokemon?.name);
                trainer2.belt[allPokemon_2].closes();
                allPokemon_1 += 1;
                allPokemon_2 += 1;
            }


        }
        else if (defeated_pokemon1 == true)
        {
            Console.WriteLine(trainer1.Name + " calls back " + trainer1.belt[pokemon_trainer1].pokemon?.name);
            trainer1.belt[pokemon_trainer1].closes();
            defeated_pokemon1 = false;
            allPokemon_1 += 1;

        }
        else if (defeated_pokemon2 == true)
        {
            Console.WriteLine(trainer2.Name + " calls back " + trainer2.belt[pokemon_trainer2].pokemon?.name);
            trainer2.belt[pokemon_trainer2].closes();
            defeated_pokemon2 = false;
            allPokemon_1 += 1;

        }

    }
}