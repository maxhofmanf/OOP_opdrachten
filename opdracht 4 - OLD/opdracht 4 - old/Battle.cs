using game;
class Battle
{
    public static string winner;
    public static string? previous_winner;
    public static bool defeated_pokemon1;
    public static bool defeated_pokemon2;


    public static string Fight(Trainer trainer1, Trainer trainer2, int[] scoreboard, int round)
    {
        int trainer_pokemon1 = 0;
        int trainer_pokemon2 = 0;

        while (scoreboard[0] < 6 || scoreboard[1] < 6)
        {
            if (trainer1.belt[trainer_pokemon1].pokemon?.weakness == trainer2.belt[trainer_pokemon2].pokemon?.strength)
            {
                winner = trainer2.Name;
                previous_winner = trainer2.Name;
                scoreboard[0] += 1;
                defeated_pokemon1 = true;
            }
            else if (trainer1.belt[trainer_pokemon1].pokemon?.strength == trainer2.belt[trainer_pokemon2].pokemon?.weakness)
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
            Console.WriteLine("its round: " + round);
            trainer1.ThrowBall(trainer_pokemon1, trainer1);
            trainer2.ThrowBall(trainer_pokemon2, trainer2);
            Console.Write("");
            trainer1.belt[trainer_pokemon1].pokemon?.battleCry();
            Console.WriteLine("");


            trainer2.belt[trainer_pokemon2].pokemon?.battleCry();
            Console.WriteLine("");

            Console.WriteLine(winner + " wins");
            Console.WriteLine("");

            if (winner == "nobody wins")
            {
                if (previous_winner == null)
                {
                    Console.WriteLine(trainer1 + " calls back " + trainer1.belt[trainer_pokemon1].pokemon?.name);
                    trainer1.belt[trainer_pokemon1].closes();

                    Console.WriteLine(trainer2 + " calls back " + trainer2.belt[trainer_pokemon2].pokemon?.name);
                    trainer2.belt[trainer_pokemon2].closes();
                    trainer_pokemon1 += 1;
                    trainer_pokemon2 += 1;
                }


            }
            else if (defeated_pokemon1 == true)
            {
                Console.WriteLine(trainer1.Name + " calls back " + trainer1.belt[trainer_pokemon1].pokemon?.name);
                trainer1.belt[trainer_pokemon1].closes();
                defeated_pokemon1 = false;
                trainer_pokemon1 += 1;

            }
            else if (defeated_pokemon2 == true)
            {
                Console.WriteLine(trainer2.Name + " calls back " + trainer2.belt[trainer_pokemon2].pokemon?.name);
                trainer2.belt[trainer_pokemon2].closes();
                defeated_pokemon2 = false;
                trainer_pokemon1 += 1;

            }

            Console.WriteLine("the score is:  " + scoreboard[0] + " : " + scoreboard[1]);

            Console.WriteLine("");

            Console.WriteLine("");
            if (scoreboard[0] >= 6)
            {
                return trainer1.Name;
            }
            else if (scoreboard[1] >= 6)
            {
                return trainer2.Name;
            }
            else
            {
                return "";
            }
        }
    }
}