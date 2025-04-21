namespace NumberGuessing
{
    public class NumberGuessing {
        int userGuess;
        int limit = 10;
        int numberOfAttempts;
        public static int bestScore = int.MaxValue;

        public void NumberGuessingGame(int randomNumber) {
            numberOfAttempts = 0;
    
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
                    Console.WriteLine("You guessed it. Congratulations!");
                    if (numberOfAttempts < bestScore)
                    {
                        bestScore = numberOfAttempts;
                        Console.WriteLine("New high score!");
                    }

                    Console.WriteLine($"Attempts this game: {numberOfAttempts}");
                    Console.WriteLine($"Best score so far: {bestScore} attempts");
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
                        Console.WriteLine("You ran out of attempts");
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
                bestScore = int.MaxValue;
                return false;
            }
            else if (userConfirmation == "Y" || userConfirmation == "YES")
            {
                numberOfAttempts = 0;
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