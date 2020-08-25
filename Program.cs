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
            // Console.Beep(700, 1000);
            // Console.Beep(450, 1000);
            // Console.Beep(550, 150);
            // Console.Beep(620, 150);
            // Console.Beep(700, 850);
            // Console.Beep(450, 850);
            // Console.Beep(550, 150);
            // Console.Beep(620, 150);
            // Console.Beep(520, 2000);
            // Console.Beep(620, 1000);
            // Console.Beep(420, 800);
            // Console.Beep(520, 150);
            // Console.Beep(550, 150);
            // Console.Beep(620, 1000);
            // Console.Beep(420, 800);
            // Console.Beep(550, 150);
            // Console.Beep(520, 150);
            // Console.Beep(450, 2000);

            Console.WriteLine(@"You've been wandering a seemingly endless expanse of country side, searching for the man who killed your brother. 
You brush dried blood off your knuckles, still raw from beating answers out of a pair of scoundrels you happened upon last night. 
Your hands for their directions to the Notched Dragon Tavern - a fair trade.");
            Console.WriteLine("You continue down the rocky path...");
            Console.ReadLine();
            Console.WriteLine("You crest the hilltop and see the tavern, obfuscated in overgrowth, tucked off the main path.");
            Console.WriteLine("You draw nearer...");
            Console.ReadLine();

            Console.WriteLine(@"From the outside it looks cheerless, dull and broken. Softwooden planks and wooden pillars make up most of the building's outer structure.
It's difficult to see through the large, curtained windows, but the awkward silence from within can be felt outside.");
            Console.WriteLine("Against your better judgement, you enter the buidling...");
            Console.ReadLine();

            Console.WriteLine(@"As you enter the tavern through the dirty, wooden door, you're welcomed by the smell of alcohol and thick air.
The bartender is lying in a chair, doing nothing and makes no effort to acknowledge your pressence.");
            Console.WriteLine("About the warmest welcome you've received since the night your brother died...");
            Console.ReadLine();

            Console.WriteLine(@"It's as horrible inside as it is on the outside. Squared, wooden beams support the upper floor and the light fixtures attached to them. 
The walls are decorated with mounted animal heads and small animals, though most have become worn and broken, given the place an even creapier feel.");
            Console.WriteLine("Quite the trophy collection, you hope you aren't next...");
            Console.ReadLine();

            Console.WriteLine(@"The tavern itself is almost completely abanonded. The few people inside appear to be dangerous in one way or another, but whoever they are, it makes you a little nervous. 
You did hear rumors about this tavern, supposedly it's infamous for something, but for the life of you you can't remember what for. 
Though juding by judging by the people in this place, it's probably something shady and possibly dangerous for strangers like you.");
            Console.WriteLine("The hairs on the back of your neck stand up...");
            Console.ReadLine();

            Console.WriteLine("From the shadows, a shrouded figure emerges...");
            Console.ReadLine();
            Console.WriteLine("\"We know what answers you seek, traveller. Naught is hidden from the watching eyes of my ravens...\"");
            Console.WriteLine("Your hand slowly nears your sword hilt...");
            Console.ReadLine();

            Console.WriteLine("\"For you, answer. For us, a game. But first...tell us...who are you? A shrew? A mongoose? A bear?\"");
            Console.WriteLine("\"Or are you perhaps...a dragon?\"");
            Console.WriteLine();

            Console.WriteLine("You asked yourself...\"Well...what am I?\"");
            string Difficulty = Console.ReadLine();
            Console.WriteLine();
            if (Difficulty == "shrew")
            {
                DifficultySelection = 8;
            }
            else if (Difficulty == "mongoose")
            {
                DifficultySelection = 6;
            }
            else if (Difficulty == "bear")
            {
                DifficultySelection = 4;
            }
            else if (Difficulty == "dragon")
            {
                DifficultySelection = 57462745;
            }

            Console.WriteLine("The shadowy figure cackles and opens its shawl to reveal a glowing green amulet");
            Console.WriteLine();

            for (int i = 0; i < DifficultySelection; i++)
            {
                Console.Write($"Tell me...how many souls of arrogant adventurers are trapped in my amulet? This is guess {i+1}:  ");
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
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"Pathetic! Are you even trying? Your number is too low! You have {DifficultySelection-i-1} guesses remaining...");
                        Console.WriteLine();
                    }

                }
            }
        }
    }
}