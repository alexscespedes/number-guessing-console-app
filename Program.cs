namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int gameLevel;
            // int userGuess;
            // int limit = 10;
            // int numberOfAttempts = 0;
            bool exit = false;
            bool confirmation = true;

            // Implement different difficulty levels (different ranges): 
            // 
            // Medium: 1, 1000,
            // Hard: 1, 10000

            while(!exit) 
            {
                Console.WriteLine("Welcome to the Number Guessing Game!");
                Console.WriteLine("1 for Junior - Random Numbers: (1,100)");
                Console.WriteLine("2 for Intermediate - Random Numbers: (1,1000)");
                Console.WriteLine("3 for Senior - Random Numbers: (1,10000)");
                Console.WriteLine("4 for Exit the Program");
                Console.Write("Choose an option: ");
                if (!int.TryParse(Console.ReadLine(), out int userLevelInput)) 
                {
                    Console.WriteLine("Invalid input! Please enter a valid integer");
                    break;
                }

                var numberGuessing = new NumberGuess();

                switch (userLevelInput)
                {
                    case 1:
                        Console.WriteLine("Junior Level");
                        // do
                        // {
                        gameLevel = random.Next(1, 5);
                        numberGuessing.NumberGuessingGame(gameLevel);

                        // } while (confirmation);
                        break;
                    
                    case 2:
                        Console.WriteLine("Intermediate Level");
                        gameLevel = random.Next(1, 10);
                        numberGuessing.NumberGuessingGame(gameLevel);
                        break;

                    case 3:
                        Console.WriteLine("Senior Level");
                        gameLevel = random.Next(1, 15);
                        numberGuessing.NumberGuessingGame(gameLevel);
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