
namespace game
{


    class BattleSim
    {
        static void Main(string[] args)
        {

            string? answer = "";
            while (answer != "quit")
            {
                Console.Write("hoe wil je trainer noemen? : ");
                string? new_name1;
                new_name1 = Console.ReadLine();

                Console.Write("hoe wil je tweede trainer noemen? : ");
                string? new_name2;
                new_name2 = Console.ReadLine();
                Trainer trainer1 = new Trainer(new_name1);
                Console.WriteLine("pire");
                Trainer trainer2 = new Trainer(new_name2);
                for (int x = 0; x < 6; x++)
                {
                    Console.WriteLine(trainer1.Name + " sends out " + trainer1.belt[x].charmander?.name);

                    Console.WriteLine(trainer2.Name + " sends out " + trainer1.belt[x].charmander?.name);

                    Console.WriteLine();

                }
                Console.Write("type quit to stop: ");
                answer = Console.ReadLine();
            }
        }
    }
}



// {
//     class Charmander
//     {
//         public string? name { get; set; }
//         string strength, weakness = "";
//         public Charmander(string? name, string weakness, string strength)
//         {
//             this.name = name;
//             this.weakness = weakness;
//             this.strength = strength;

//         }
//         public void battleCry()
//         {
//             Console.WriteLine(this.name + " used battle cry: " + this.name + "!");
//         }
//     }
//     class Pokeball
//     {
//         public Charmander? charmander;


//         public Pokeball()
//         {

//         }
//         public void Capture(Charmander charmander)
//         {
//             this.charmander = charmander;
//             Console.WriteLine("Charmander has been captured");
//         }
//         public bool checkEmpty()
//         {
//             return this.charmander != null;
//         }

//     }
//     class Trainer
//     {
//         public string? Name { get; set; }
//         public List<Pokeball> belt;
//         public Trainer(string? Name)
//         {
//             this.Name = Name;
//             belt = new List<Pokeball>();
//             for (int i = 0; i < 6; i++)
//             {
//                 belt.Add(new Pokeball());
//                 belt[i].Capture(new Charmander("sparky", "water", "fire"));
//             }
//         }
//         public void throwball(Trainer trainer)
//         {
//             foreach (Pokeball ball in belt)
//             {
//                 if (belt[0].checkEmpty())
//                 {
//                     Console.WriteLine("this pokeball is full");
//                 }
//                 else
//                 {
//                     Console.WriteLine("this pokeball is empty.");
//                 }
//             }
//         }

//     }
//     class BattleSim
//     {
//         static void Main(string[] args)
//         {

//             string? answer = "";
//             while (answer != "quit")
//             {
//                 Console.Write("hoe wil je trainer noemen? : ");
//                 string? new_name1;
//                 new_name1 = Console.ReadLine();

//                 Console.Write("hoe wil je tweede trainer noemen? : ");
//                 string? new_name2;
//                 new_name2 = Console.ReadLine();
//                 Trainer trainer1 = new Trainer(new_name1);
//                 Console.WriteLine("pire");
//                 Trainer trainer2 = new Trainer(new_name2);
//                 for (int x = 0; x < 6; x++)
//                 {
//                     Console.WriteLine(trainer1.Name + " sends out " + trainer1.belt[x].charmander?.name);

//                     Console.WriteLine(trainer2.Name + " sends out " + trainer1.belt[x].charmander?.name);

//                     Console.WriteLine();

//                 }
//                 Console.Write("type quit to stop: ");
//                 answer = Console.ReadLine();
//             }
//         }
//     }
// }