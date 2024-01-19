using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do
        {
            
        
            // get a number to be guessed
            // Console.Write("What is a number? ");
            // int number = int.Parse(Console.ReadLine());
            int guess;

            // randomly choose a number
            Random randomNumber = new Random();
            int number = randomNumber.Next(0,101);
            int guessCount = 0;

            do
            {
                // ask the user for a guess, loop until they guess it

                Console.Write("Guess a number between 0-100: ");
                guess = int.Parse(Console.ReadLine());
                guessCount += 1;

                // Using an if statement, determine if the user needs to guess higher or lower next time, or tell them if they guessed it.

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You got it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            } while (guess != number);

            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();

        } while (playAgain == "yes");

    }
}