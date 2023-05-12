namespace game
{
    class Pokeball
    {
        bool ball_state;
        public Pokeball(bool ball_state)
        {
            this.ball_state = ball_state;
        }

    }
    class Charmander
    {
        string? name;
        string? weakness;
        string? strength;
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
    class Trainer
    {
        string? name;
        public Trainer(string? name)
        {
            this.name = name;
        }
    }
    class BattleSim
    {

        static void Main(string[] args)
        {
            Pokeball pokeball = new Pokeball(false);


        }
    }
}