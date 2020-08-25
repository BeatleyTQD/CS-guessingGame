using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Weary traveller, what is the secret number?  ");
                string answer = Console.ReadLine();
                int answerNum = int.Parse(answer);

                if (answerNum == secretNumber)
                {
                    Console.WriteLine("Praise Muloch, glory be his name!");
                }
                else
                {
                    Console.WriteLine("Do not toy with me, child!");
                }
            }
        }
    }
}