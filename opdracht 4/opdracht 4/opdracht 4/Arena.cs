using game;
class Arena
{
    
    
    
    public static void Rounds(Trainer trainer1, Trainer trainer2 )
    {
        int x = 0;
        int[] scoreboard = { 0, 0 };
        while (scoreboard[0] < 6 && scoreboard[1] < 6)
        {
            Console.WriteLine(scoreboard[0] + " " + scoreboard[1]);
            x++; 
            Console.WriteLine("Scoreboard: ");
            Console.WriteLine("its round" + x);
            Battle.Fight(trainer1, trainer2, scoreboard);
        }
    }


}
