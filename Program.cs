using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;
            Console.Write("Weary traveller, what is the secret number?  ");
            string answer = Console.ReadLine();
            int answerNum = int.Parse(answer);

            if (answerNum == secretNumber)
            {
                Console.WriteLine("Welcome aboard, agent");
            }
            else
            {
                Console.WriteLine("Guards, kill this intruder!");
            }
        }
    }
}