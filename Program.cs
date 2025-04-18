namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1,10);
            int userGuess;
            int limit = 10;
            int numberOfAttempts = 0;
            bool exit = false;
            //bool confirmation = true;

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
                Console.Write("Choose the difficulty level to play: ");
                if (!int.TryParse(Console.ReadLine(), out int userLevelInput)) 
                {
                    Console.WriteLine("Invalid input! Please enter a valid integer");
                    break;
                }

                switch (userLevelInput)
                {
                    case 1:
                        // Junior
                        break;
                    
                    case 2:
                        // Intermediate
                        break;

                    case 3:
                        // Senior
                        break;
                    case 4:
                        // Goodbye!
                        break;
                    
                    default:
                        break;
                }

            }



            while (true) 
            {
                Console.Write("Try to guess the number: ");
                while (true)
                {
                    Console.Write("Try to guess the number: ");
                    if (int.TryParse(Console.ReadLine(), out userGuess))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid input! Please enter a valid number."); 
                }

                if (userGuess == randomNumber)
                {
                    Console.WriteLine("Your guessed it. Congratulations!");
                    int highscore = limit - numberOfAttempts;
                    Console.WriteLine($"Your highscore was: {highscore}");
                    break;
                }

                else if (userGuess != randomNumber)
                {
                    numberOfAttempts++;
                    if (numberOfAttempts < limit)
                    {
                        string message = (userGuess > randomNumber) ? "Too high" : "Too low";
                        Console.WriteLine(message);
                        // score--;
                        Console.WriteLine($"Number of guesses made: {numberOfAttempts}");
                    }
                    else 
                    {
                        Console.WriteLine("You runs out of attempts");
                        break;
                    }
                    
                }
            }

        }
    }
}