namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool exit = false;
            bool confirmation;

            while(!exit) 
            {
                Console.WriteLine("Welcome to the Number Guessing Game!");
                Console.WriteLine("1 for Junior - Random Numbers: (1, 100)");
                Console.WriteLine("2 for Intermediate - Random Numbers: (1, 500)");
                Console.WriteLine("3 for Senior - Random Numbers: (1, 999)");
                Console.WriteLine("4 for Exit the Program");
                Console.Write("Choose an option: ");
                if (!int.TryParse(Console.ReadLine(), out int userLevelInput)) 
                {
                    Console.WriteLine("Invalid input! Please enter a valid integer");
                    break;
                }

                var numberGuessing = new NumberGuessing();

                switch (userLevelInput)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Junior Level");
                            int juniorLevel = random.Next(1, 26);
                            numberGuessing.NumberGuessingGame(juniorLevel);

                            confirmation = numberGuessing.MultipleGamesInOneSession();
                        } while (confirmation);
                        break;
                    
                    case 2:
                        do
                        {
                            Console.WriteLine("Intermediate Level");
                            int intermediateLevel = random.Next(1, 51);
                            numberGuessing.NumberGuessingGame(intermediateLevel);

                            confirmation = numberGuessing.MultipleGamesInOneSession();
                        } while (confirmation);
                        break;

                    case 3:
                        do
                            {
                            Console.WriteLine("Senior Level");
                            int seniorLevel = random.Next(1, 76);
                            numberGuessing.NumberGuessingGame(seniorLevel);

                            confirmation = numberGuessing.MultipleGamesInOneSession();
                        } while (confirmation);
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        exit = true;
                        break;
                    
                    default:
                        Console.WriteLine("Invalid option. Try again!");
                        break;
                }
            }
        }
    }
}