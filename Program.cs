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
            String response = "";

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);
                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + ": ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);
                    if (guess > number)
                    {
                        Console.WriteLine("Your value is higher than the random number. Try Again!");
                    } else if (guess < number)
                    {
                        Console.WriteLine("Your value is lower than the random number. Try Again!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You Win!!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again? Y or N?");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (ApplicationException.Equals(response, "Y"))
                {
                    playAgain = true;
                } else if (ApplicationException.Equals(response, "N"))
                {
                    playAgain = false;
                } else
                {
                    Console.WriteLine("Enter a valid value (Y/N)");
                }
            }
            Console.WriteLine("Thanks for Playing!");
            Console.ReadKey();
        }
    }
}
