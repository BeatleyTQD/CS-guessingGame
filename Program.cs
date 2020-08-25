using System;
using System.Threading;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int SecretNumber = new Random().Next(1, 100);
            int DifficultySelection = 0;

            Console.WriteLine("Welcome, traveller...are you feeling very easy, medium, or hard today? Also definitely do NOT type \"cheater\"");
            Console.Beep(700, 1000);
            Console.Beep(450, 1000);
            Console.Beep(550, 150);
            Console.Beep(620, 150);
            Console.Beep(700, 850);
            Console.Beep(450, 850);
            Console.Beep(550, 150);
            Console.Beep(620, 150);
            Console.Beep(520, 2000);
            Console.Beep(620, 1000);
            Console.Beep(420, 800);
            Console.Beep(520, 150);
            Console.Beep(550, 150);
            Console.Beep(620, 1000);
            Console.Beep(420, 800);
            Console.Beep(550, 150);
            Console.Beep(520, 150);
            Console.Beep(450, 800);

            string Difficulty = Console.ReadLine();

            if (Difficulty == "easy")
            {
                DifficultySelection = 8;
            }
            else if (Difficulty == "medium")
            {
                DifficultySelection = 6;
            }
            else if (Difficulty == "hard")
            {
                DifficultySelection = 4;
            }
            else if (Difficulty == "cheater")
            {
                DifficultySelection = 57462745;
            }

            for (int i = 0; i < DifficultySelection; i++)
            {
                Console.Write($"Tell me...what is the secret number? This is guess {i+1}:  ");
                string Answer = Console.ReadLine();
                int AnswerNum = int.Parse(Answer);

                if (AnswerNum == SecretNumber)
                {
                    Console.WriteLine("Praise Muloch, glory be his name!");
                    break;
                }
                else
                {
                    if (AnswerNum > SecretNumber)
                    {
                        Console.WriteLine($"Do not toy with me, child, your number was too high! You have {DifficultySelection-i-1} guesses remaining...");
                    }
                    else
                    {
                        Console.WriteLine($"Do not toy with me, child, your number is too low! You have {DifficultySelection-i-1} guesses remaining...");
                    }

                }
            }
        }
    }
}