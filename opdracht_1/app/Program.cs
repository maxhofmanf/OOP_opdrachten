namespace game
{
    class Charmander
    {
        string? name;
        string strength, weakness = "";
        public Charmander(string? name, string weakness, string strength)
        {
            this.name = name;
            this.weakness = weakness;
            this.strength = strength;
        }
        public void battleCry()
        {
            Console.WriteLine(this.name + " used battle cry: " + this.name + "!");
        }
    }
    class BattleSim
    {
        static void Main(string[] args)
        {

            string? antwoord = "";
            while (antwoord != "quit")
            {
                Console.Write("hoe wil je charmander noemen? : ");
                string? new_name;
                new_name = Console.ReadLine();
                Charmander charmander = new Charmander(new_name, "water", "fire");
                for (int x = 0; x < 10; x++)
                {
                    charmander.battleCry();
                }
                Console.Write("type quit to stop: ");
                antwoord = Console.ReadLine();
            }
        }
    }
}