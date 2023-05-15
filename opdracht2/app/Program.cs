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
    class Pokeball
    {
        public Charmander? charmander;

        string? pokemon_name;
        bool status;
        public void Capture(Charmander charmander)
        {
            this.charmander = charmander;
            Console.WriteLine("Charmander has been captured");
        }

    }
    class Trainer
    {
        string? name;
        public List<Pokeball> belt;
        public Trainer(string? name)
        {
            this.name = name;
            belt = new List<Pokeball>();
            for (int i = 0; i < 6; i++)
            {
                belt.Add(new Pokeball());
                belt[i].Capture(new Charmander("na", "water", "fire"));
            }
        }

    }
    class BattleSim
    {
        static void Main(string[] args)
        {

            string? antwoord = "";
            while (antwoord != "quit")
            {
                Console.Write("hoe wil je trainer noemen? : ");
                string? first_trainer_name;
                first_trainer_name = Console.ReadLine();
                Console.Write("hoe wil je tweede trainer noemen? : ");
                string? second_trainer_name;
                second_trainer_name = Console.ReadLine();

                Console.Write("type quit to stop: ");
                antwoord = Console.ReadLine();
            }
        }
    }
}