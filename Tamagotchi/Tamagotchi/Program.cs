namespace Tamagotchi
{
    internal class Program
    {
        private static Pokemon pika = new Pokemon("Pikachu", 5);
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)

            {   
                Console.Clear();
                pika.RandomEvent();
                pika.DisplayInfo();
                Console.WriteLine($"You are on day :{pika.GetDayCounter()} with {pika.GetName()} aged {pika.GetAge()}");

                Console.WriteLine("\n1.Feed Pikachu");
                Console.WriteLine("2.Play with Pikachu");
                Console.WriteLine("3.Pee");
                Console.WriteLine("4.Pass Time");
                Console.WriteLine("5.Add pokemon");
                Console.WriteLine("6.Exit");
                var inputChoice = Console.ReadLine();
                switch (inputChoice)
                {
                    case "1":
                        Console.Clear();
                        pika.Feed();
                        break;
                    case "2":
                        Console.Clear();
                        pika.Play();
                        break;
                    case "3":
                        Console.Clear();
                        pika.Pee();
                        break;
                    case "4":
                        Console.Clear();
                        pika.PassTime();
                        break;
                    case "5":
                        Console.Clear();
                        pika.AddPokemon();
                        break;
                    case "6":
                        isRunning = false;
                        break;
                }

            }
        }
    }
}
