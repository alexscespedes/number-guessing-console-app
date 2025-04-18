namespace NumberGuessing
{
    public class NumberGuessing {
        // Random random = new Random();
        // int randomNumber;
        int userGuess;
        int limit = 10;
        int numberOfAttempts = 0;
        public void NumberGuessingGame(int randomNumber) {
            while (true) 
            {
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