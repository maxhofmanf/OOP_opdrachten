
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


        public void addPokemon()
        {
            Charmander charmander = new Charmander("sparky", "water", "fire");
            this.charmander = charmander;
        }
        public void open()
        {
            if (charmander != null)
            {
                charmander.battleCry();
            }
        }

    }
    class Trainer
    {
        public string? Name;
        public List<Pokeball> belt;

        public Trainer(string? Name)
        {
            this.Name = Name;
            belt = new List<Pokeball>();

            for (int i = 0; i < 6; i++)
            {
                belt.Add(new Pokeball());
            }
        }



        class BattleSim
        {
            static void Main(string[] args)
            {

                string? antwoord = "";
                while (antwoord != "quit")
                {

                }
            }
        }
    }

}
