using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
           int randomNumber = 0;

            int NumberEnteredByUser = 0;
            int TimeGuessed = 0;
            string Level;
            int GuessLimit = 0;

            Console.WriteLine("WELCOME TO Sarakiri Akpos Random Number Guessing Game!");

            // TODO: Create a game that picks a random number and then gives the user 3 Levels to guess.

            Console.WriteLine("Select your preferred Level, select H for Hard, M for Medium and E for Easy");
            Level = Console.ReadLine();

            // With each incorrect answer tell the user if the correct answer is higher or lower.
            // At the end ask if they want to play again or end.

            if (Level == "E")
            {
                GuessLimit = 4;
                Random random = new Random();
                randomNumber = random.Next(1, 10);
                Console.WriteLine($"Hint: Its a number from 1 - 10, You have {GuessLimit} Guesses");
            }
            else if (Level == "M")
            {
                Random random = new Random();
                randomNumber = random.Next(1, 20);
                GuessLimit = 8;
                Console.WriteLine($"Hint: Its a number from 1 - 20, You have {GuessLimit} Guesses");
            }

            else if (Level == "H")
            {
                Random random = new Random();
                randomNumber = random.Next(1, 50);
                GuessLimit = 2;
                Console.WriteLine($"Hint: Its a number from 1 - 50, You have {GuessLimit} Guesses");
            }

            bool OutOfGuesses = false;
            while (NumberEnteredByUser != randomNumber && !OutOfGuesses)
            {
                if (TimeGuessed < GuessLimit)
                {
                    Console.WriteLine("What's Your Guess");
                    NumberEnteredByUser = int.Parse(Console.ReadLine());
                    if (NumberEnteredByUser != randomNumber)
                    {
                        Console.WriteLine("That was Wrong, Please Try again");
                    }
                 
                    TimeGuessed++;
                }
                else
                {
                    OutOfGuesses = true;
                }


            }
            if (OutOfGuesses)
            {
                Console.WriteLine($"Out of Guesses, You Loose. The correct number is {randomNumber}");
            }
            else
            {
                Console.WriteLine("Congrats! You got it right!");
            }

            Console.ReadLine();
        }
    }
}
