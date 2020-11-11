using System;

namespace _06_boolean_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1-10");

            int guessNumber = Convert.ToInt16(Console.ReadLine());
            

            if (guessNumber == 5)
            {
                Console.WriteLine("Nice job! You guessed correctly");
            }
            if (guessNumber < 5)
            {
                Console.WriteLine("Choose a higher number");
            }
            if (guessNumber > 5)
            {
                Console.WriteLine("Choose a lower number");
            }
            Console.ReadLine();
        }
    }
}
