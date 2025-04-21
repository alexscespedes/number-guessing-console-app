namespace NumberGuessing
{
    public class NumberGuessing {
        int userGuess;
        int highscore;
        int limit = 10;
        int numberOfAttempts;
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
                    highscore = limit - numberOfAttempts;
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

        public bool MultipleGamesInOneSession() {
            Console.Write("Do you want to play another game in the same session level (Y/N): ");
            string? userConfirmation = Console.ReadLine()?.Trim().ToUpper();
                                        
            if (userConfirmation == "N" || userConfirmation == "NO")
            {
                return false;
            }
            else if (userConfirmation == "Y" || userConfirmation == "YES")
            {
                numberOfAttempts = 0;
                highscore = 0;
                return true;
            }
            else 
            {
                Console.WriteLine("Invalid input!");
                return false;
            }
        }
    }
}