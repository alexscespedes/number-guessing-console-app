namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1,100);
            bool exit = false;
            while (!exit) 
            {
                Console.WriteLine("Welcome to the Number Guessing Game!");
                Console.Write("Try to guess the number: ");
                if (!int.TryParse(Console.ReadLine(), out int userGuess)) 
                {
                    Console.WriteLine("Invalid input! Please enter a valid integer");
                }

                if (userGuess > randomNumber)
                {
                    Console.WriteLine("The number is lower.");
                }
                else if (userGuess < randomNumber) 
                {
                    Console.WriteLine("The number is higher.");
                }
                else {
                    Console.WriteLine("Your guessed it. Congratulations!");
                    exit = true;
                }
            }


        }
    }
}