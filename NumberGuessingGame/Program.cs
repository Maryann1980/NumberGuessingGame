namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");


            // Generate a random number between 1 and 100
            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            Console.WriteLine($"Secret Number: {secretNumber}");//displaying the number 


            int attempts = 0;
            int guess = 0;

            Console.WriteLine("Try to guess the number between 1 and 100.");

            // Main game loop
            while (guess != secretNumber)
            {
                Console.Write("Enter your guess: ");

                // Validate user input
                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write("Enter your guess: ");
                }

                attempts++;

                // Check if the guess is correct, too high, or too low
                if (guess == secretNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low. Try again.");
                }
                else
                {
                    Console.WriteLine("Too high. Try again.");
                }
            }

            Console.ReadLine();
            // Keep console window open

        }
    }
}
