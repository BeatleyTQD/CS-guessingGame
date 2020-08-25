using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 100);
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Weary traveller, what is the secret number? This is guess {i+1}:  ");
                string answer = Console.ReadLine();
                int answerNum = int.Parse(answer);

                if (answerNum == secretNumber)
                {
                    Console.WriteLine("Praise Muloch, glory be his name!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Do not toy with me, child! You have {3-i} guesses remaining...");
                }
            }
        }
    }
}