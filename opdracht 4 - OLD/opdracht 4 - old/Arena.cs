using game;

class Arena
{
    public int[] scoreboard = { 0, 0 };
    public int round = 0;
    public int trainer_pokemon1 = 0;
    public int trainer_pokemon2 = 0;
    public Arena(int[] scoreboard, int round)
    {
        this.scoreboard = scoreboard;
        this.round = round;
    }

    public static void Rounds(Trainer trainer1, Trainer trainer2, int[] scoreboard, int round,  int trainer_pokemon1,  int trainer_pokemon2)
    {
        Battle.Fight(trainer1, trainer2, scoreboard, round, trainer_pokemon1, trainer_pokemon2);
    }
}