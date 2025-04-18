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

            // Implement different difficulty levels (different ranges): 
            // Easy: 1,100  
            // Medium: 1, 1000,
            // Hard: 1, 10000

            Console.WriteLine("Welcome to the Number Guessing Game!");
            while (!exit) 
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
                    exit = true;
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
                        exit = true;
                    }
                    
                }
            }


        }
    }
}