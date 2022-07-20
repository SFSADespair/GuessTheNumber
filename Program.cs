using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number;
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess = 0;
            int guesses = 0;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1);
                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + ": ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);
                }
            }
            
            Console.ReadKey();
        }
    }
}
