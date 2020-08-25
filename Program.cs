﻿using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int SecretNumber = new Random().Next(1, 100);
            int DifficultySelection = 0;

            Console.WriteLine("Welcome, traveller...are you feeling very easy, medium, or hard today?");
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