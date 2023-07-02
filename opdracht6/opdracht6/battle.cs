
class Battle
{
    public static string? previous_winner;

    public static void Fight(Trainer trainer1, Trainer trainer2, int[] scoreboard, ref int pokemon_trainer1, ref int pokemon_trainer2)
    {
        string? winner = "";

        bool defeated_pokemon1 = false;
        bool defeated_pokemon2 = false;
        
        if (trainer1.belt[pokemon_trainer1].pokemon?.getWeakness() == trainer2.belt[pokemon_trainer2].pokemon?.getStrength())
        {
            trainer1.belt[pokemon_trainer1].pokemon.status = false;

            winner = trainer2.Name;
            previous_winner = trainer2.Name;
            scoreboard[1] += 1;
            defeated_pokemon1 = true;
        }
        else if (trainer1.belt[pokemon_trainer1].pokemon?.getStrength() == trainer2.belt[pokemon_trainer2].pokemon?.getWeakness())
        {
            trainer2.belt[pokemon_trainer2].pokemon.status = false;

            winner = trainer1.Name;
            previous_winner = trainer1.Name;
            scoreboard[0] += 1;
            defeated_pokemon2 = true;

            
                
        }
        else
        {
            winner = "nobody";
        }

        trainer1.ThrowBall(pokemon_trainer1, trainer1);
        trainer2.ThrowBall(pokemon_trainer2, trainer2);
        Console.Write("");
        trainer1.belt[pokemon_trainer1].pokemon?.BattleCry();
        Console.WriteLine("");

        trainer2.belt[pokemon_trainer2].pokemon?.BattleCry();
        Console.WriteLine("");

        Console.WriteLine(winner + " wins");
        Console.WriteLine("");

        if (winner == "nobody")
        {
            if (previous_winner == null)
            {
                Console.WriteLine(trainer1.Name + " calls back " + trainer1.belt[pokemon_trainer1].pokemon?.name);
                trainer1.belt[pokemon_trainer1].closes();

                Console.WriteLine(trainer2.Name + " calls back " + trainer2.belt[pokemon_trainer2].pokemon?.name);
                trainer2.belt[pokemon_trainer2].closes();
                trainer1.belt[pokemon_trainer1].pokemon.status = false;
                trainer2.belt[pokemon_trainer2].pokemon.status = false;
                pokemon_trainer1 += 1;
                pokemon_trainer2 += 1;
            } else if(previous_winner == trainer1.Name)
            {
                Console.WriteLine(trainer2.Name + " calls back " + trainer2.belt[pokemon_trainer2].pokemon?.name);
                trainer2.belt[pokemon_trainer2].closes();
                trainer2.belt[pokemon_trainer2].pokemon.status = false;

                pokemon_trainer2 += 1;


            }
            else if (previous_winner == trainer2.Name)
            {
                Console.WriteLine(trainer1.Name + " calls back " + trainer1.belt[pokemon_trainer1].pokemon?.name);
                trainer1.belt[pokemon_trainer1].closes();
                trainer1.belt[pokemon_trainer1].pokemon.status = false;

                pokemon_trainer1 += 1;


            }

        }
        else if (defeated_pokemon1)
        {
            Console.WriteLine(trainer1.Name + " calls back " + trainer1.belt[pokemon_trainer1].pokemon?.name);
            trainer1.belt[pokemon_trainer1].closes();
            defeated_pokemon1 = false;
            trainer1.belt[pokemon_trainer1].pokemon.status = false;

            pokemon_trainer1 += 1;


        }
        else if (defeated_pokemon2)
        {
            Console.WriteLine(trainer2.Name + " calls back " + trainer2.belt[pokemon_trainer2].pokemon?.name);
            trainer2.belt[pokemon_trainer2].closes();
            defeated_pokemon2 = false;
            trainer2.belt[pokemon_trainer2].pokemon.status = false;

            pokemon_trainer2 += 1;

        }

    }

}