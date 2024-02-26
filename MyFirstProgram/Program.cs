
using System.Transactions;

namespace MyFirstProgram 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Random rnd = new Random();
            int min = 1;
            int max = 10;
            int guess;
            int answer;
            int guessesHad = 0;
            int guessesRemaining = 3;
            String playAgain;

            bool running = true;
            answer = rnd.Next(min, max + 1);

            Console.WriteLine("Welcome to the guessing game!\n");

            while (running) 
            {
                Console.WriteLine("Guess a number between 1 - 10: ");
                Console.Write("$> ");
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Incorrect guess.\nTry again.\n");
                    continue;
                }

                if (guess < min || guess > max) 
                {
                    Console.WriteLine("Guess is out of bounds.\nTry again.\n");
                    continue;
                }
                guessesRemaining--;

                Console.WriteLine("You guessed " + guess);

                if (guess == answer)
                {
                    Console.WriteLine("Congratulations!!\nYou guessed correctly, you win!");
                }
                else
                {
                    if (guessesRemaining > 0)
                    {
                        Console.WriteLine("Incorrect guess.\nTry again.\n");
                        continue;
                    }
                    else 
                    {
                        Console.WriteLine("Incorrect guess.\nOut of remaining guesses.\n");
                        Console.WriteLine("The correct answer is " + answer);
                    }
                }
                
                Console.WriteLine("Play again? (Y/N)");
                Console.Write("$> ");
                playAgain = Console.ReadLine();
                playAgain = playAgain.ToUpper();

                if (playAgain == "Y")
                {
                    guessesRemaining = 3;
                    continue;
                }
                else if (playAgain == "N")
                {
                    break;
                }
                else
                {

                }
                

            }


        }
    }
}

