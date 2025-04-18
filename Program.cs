namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1,100);
            int userGuess;
            int score = 10;
            int numberOfAttempts = 0;
            bool exit = false;


            // Try out a list of <int>

            // Implement different difficulty levels (different ranges): 
            // Easy: 1,100  
            // Medium: 1, 1000,
            // Hard: 1, 10000
            // Keep track of high scores (fewest guesses)


            while (!exit) 
            {
                Console.WriteLine("Welcome to the Number Guessing Game!");
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


                if (userGuess > randomNumber)
                {
                    Console.WriteLine("Too low!");
                    score--;
                    numberOfAttempts++;
                    Console.WriteLine(numberOfAttempts);
                }
                if (userGuess < randomNumber) 
                {
                    Console.WriteLine("Too high!");
                    score--;
                    numberOfAttempts++;
                    Console.WriteLine(numberOfAttempts);
                }
                else {
                    Console.WriteLine("Your guessed it. Congratulations!");
                    int highscore = score;
                    Console.WriteLine($"Your High Score was: {highscore}");
                    exit = true;
                }
            }


        }
    }
}