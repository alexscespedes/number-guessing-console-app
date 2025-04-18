namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Welcome to the Number Guessing Game!");
            int randomNumber = random.Next(1,100);
            Console.WriteLine("Guess the number: " + randomNumber);

        }
    }
}