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
            Console.WriteLine(@"
            
            Brandon Alexander Wheatley Presents...


            ▄██████▄  ███    █▄     ▄████████    ▄████████    ▄████████  ▄█  ███▄▄▄▄      ▄██████▄       
            ███    ███ ███    ███   ███    ███   ███    ███   ███    ███ ███  ███▀▀▀██▄   ███    ███      
            ███    █▀  ███    ███   ███    █▀    ███    █▀    ███    █▀  ███▌ ███   ███   ███    █▀       
           ▄███        ███    ███  ▄███▄▄▄       ███          ███        ███▌ ███   ███  ▄███             
          ▀▀███ ████▄  ███    ███ ▀▀███▀▀▀     ▀███████████ ▀███████████ ███▌ ███   ███ ▀▀███ ████▄       
            ███    ███ ███    ███   ███    █▄           ███          ███ ███  ███   ███   ███    ███      
            ███    ███ ███    ███   ███    ███    ▄█    ███    ▄█    ███ ███  ███   ███   ███    ███      
            ████████▀  ████████▀    ██████████  ▄████████▀   ▄████████▀  █▀    ▀█   █▀    ████████▀       
                                                                                                            
            ▄██████▄     ▄████████   ▄▄▄▄███▄▄▄▄      ▄████████                                          
            ███    ███   ███    ███ ▄██▀▀▀███▀▀▀██▄   ███    ███                                          
            ███    █▀    ███    ███ ███   ███   ███   ███    █▀                                           
           ▄███          ███    ███ ███   ███   ███  ▄███▄▄▄                                              
          ▀▀███ ████▄  ▀███████████ ███   ███   ███ ▀▀███▀▀▀                                              
            ███    ███   ███    ███ ███   ███   ███   ███    █▄                                           
            ███    ███   ███    ███ ███   ███   ███   ███    ███                                          
            ████████▀    ███    █▀   ▀█   ███   █▀    ██████████                                          
                                                                                                            
            ▄██████▄     ▄████████                                                                         
            ███    ███   ███    ███                                                                         
            ███    ███   ███    █▀                                                                          
            ███    ███  ▄███▄▄▄                                                                             
            ███    ███ ▀▀███▀▀▀                                                                             
            ███    ███   ███                                                                                
            ███    ███   ███                                                                                
            ▀██████▀    ███                                                                                
                                                                                                            
                ███        ▄█    █▄       ▄████████  ▄██████▄  ███▄▄▄▄      ▄████████    ▄████████          
            ▀█████████▄   ███    ███     ███    ███ ███    ███ ███▀▀▀██▄   ███    ███   ███    ███          
               ▀███▀▀██   ███    ███     ███    ███ ███    ███ ███   ███   ███    █▀    ███    █▀           
                ███   ▀  ▄███▄▄▄▄███▄▄  ▄███▄▄▄▄██▀ ███    ███ ███   ███  ▄███▄▄▄       ███                 
                ███     ▀▀███▀▀▀▀███▀  ▀▀███▀▀▀▀▀   ███    ███ ███   ███ ▀▀███▀▀▀     ▀███████████          
                ███       ███    ███   ▀███████████ ███    ███ ███   ███   ███    █▄           ███          
                ███       ███    ███     ███    ███ ███    ███ ███   ███   ███    ███    ▄█    ███          
               ▄████▀     ███    █▀      ███    ███  ▀██████▀   ▀█   █▀    ██████████  ▄████████▀  ");
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
            Console.Beep(450, 2000);
            Console.WriteLine(@"From the outside it looks cheerless, dull and broken. Softwooden planks and wooden pillars make up most of the building's outer structure.
It's difficult to see through the large, curtained windows, but the awkward silence from within can be felt outside.

As you enter the tavern through the dirty, wooden door, you're welcomed by the smell of alcohol and thick air.
The bartender is lying in a chair, doing nothing and makes no effort to acknowledge your pressence.

It's as horrible inside as it is on the outside. Squared, wooden beams support the upper floor and the light fixtures attached to them. The walls are decorated with mounted animal heads and small animals, though most have become worn and broken, given the place an even creapier feel.

The tavern itself is almost completely abanonded. The few people inside appear to be dangerous in one way or another, but whoever they are, it makes you a little nervous.

You did hear rumors about this tavern, supposedly it's infamous for something, but for the life of you you can't remember what for. Though juding by judging by the people in this place, it's probably something shady and possibly dangerous for strangers like you.");
            Console.WriteLine();
            Console.WriteLine("From the shadows, a shrouded figure emerges...");
            Console.WriteLine();
            Console.WriteLine("Welcome, traveller...tell me, are you feeling very easy, medium, or hard today? Also definitely do NOT say \"cheater\"");

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