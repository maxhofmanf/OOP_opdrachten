using System;
using System.Text;


namespace game
{
    class BattleSim
    {
        static void Main(string[] args)
        {
            int[] scoreboard = { 0, 0 };
            int round = 0;
            int trainer_pokemon1 = 0;
            int trainer_pokemon2 = 0;

            string? answer = "";

            while (answer != "quit")
            {
                Console.Write("Hoe wil je de eerste trainer noemen? : ");
                string? new_name1 = Console.ReadLine();

                Console.Write("Hoe wil je de tweede trainer noemen? : ");
                string? new_name2 = Console.ReadLine();

                Trainer trainer1 = new Trainer(new_name1);
                Trainer trainer2 = new Trainer(new_name2);

                

                while (scoreboard[0]< 6 || scoreboard[1] < 6)
                {
                    Console.Write(scoreboard[0] +" this is the score "+ scoreboard[1]);
                    round += 1;
                    Battle.Fight(trainer1, trainer2, scoreboard, round, trainer_pokemon1, trainer_pokemon2);
                }

                Console.Write("Type 'quit' to stop: ");
                answer = Console.ReadLine();
            }
        }
    }
}

