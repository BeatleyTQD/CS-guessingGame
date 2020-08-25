using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int SecretNumber = new Random().Next(1, 101);
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
               ▄████▀     ███    █▀      ███    ███  ▀██████▀   ▀█   █▀    ██████████  ▄████████▀  
               
               



               
               ");
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
            Console.ReadLine();
            Console.WriteLine(@"You've been wandering a seemingly endless expanse of country side, searching for the man who killed your brother. 
You brush dried blood off your knuckles, still raw from beating answers out of a pair of scoundrels you happened upon last night. 
Your hands for their directions - a fair trade.");
            Console.WriteLine("You continue down the rocky path...");
            Console.ReadLine();
            Console.WriteLine("Cresting the hilltop you see the tavern, obfuscated in overgrowth, tucked off the main path.");
            Console.WriteLine("Your horse lets out a disgruntled snort...");
            Console.ReadLine();

            Console.WriteLine(@"From the outside it looks cheerless, dull and broken. Softwood planks and pillars make up most of the building's outer structure.
It's difficult to see through the large, curtained windows, but the awkward silence from within can be felt outside.");
            Console.WriteLine("Against your better judgement, you enter the buidling...");
            Console.ReadLine();

            Console.WriteLine(@"As you enter the tavern through the dirty, wooden door, you're welcomed by the smell of alcohol and musty air.
The bartender is lying in a chair, doing nothing, and makes no effort to acknowledge your pressence.");
            Console.WriteLine("About the warmest welcome you've received since the night your brother died...");
            Console.ReadLine();

            Console.WriteLine(@"It's as horrible inside as it is on the outside. Squared, wooden beams support the upper floor and the light fixtures attached to them. 
The walls are decorated with mounted animal heads and small animals, though most have become worn and broken, given the place an even creepier feel.");
            Console.WriteLine("Quite the trophy collection, you hope you aren't next...");
            Console.ReadLine();

            Console.WriteLine(@"The tavern itself is almost completely abanonded. The few people inside appear to be dangerous in one way or another, but whoever they are, it makes you a little nervous.  
Not a great place for a stranger like you.");
            Console.WriteLine("The hairs on the back of your neck stand up...");
            Console.ReadLine();

            Console.WriteLine("From the shadows, a shrouded figure emerges...");
            Console.ReadLine();
            Console.WriteLine("\"We know what answers you seek, traveler. Naught is hidden from the watching eyes of my ravens...\"");
            Console.WriteLine("Your hand slowly nears your sword hilt...");
            Console.ReadLine();

            Console.WriteLine("\"For you, an answer. For us, a game. But first...tell us...who are you? A shrew? A mongoose? A bear?\"");
            Console.WriteLine("\"Or are you perhaps...a dragon?\"");
            Console.ReadLine();

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
            else
            {
                Console.WriteLine("\"Do you take me for some sort of court jester? Be gone!\"");
            }

            Console.WriteLine("The shadowy figure cackles and opens its shawl to reveal something glowing a blinding green...");

            for (int i = 0; i < DifficultySelection; i++)
            {
                Console.Write($"\"Tell me... how many arrogant adventurers are forever trapped in my amulet? This is guess {i+1}...\":  ");
                string Answer = Console.ReadLine();
                int AnswerNum = int.Parse(Answer);

                if (AnswerNum == SecretNumber)
                {
                    Console.WriteLine();
                    Console.WriteLine("A brief sideways smile flashes across the warlock's shadowy features...");
                    Console.WriteLine("\"Your brawn betrays your intellect, child...you may have a dark margic streak in you...\"");
                    Console.ReadLine();
                    Console.WriteLine("\"Until then... the answers you seek are northward, hidden where the sun is cradled by an ancient oak in a valley bereft of life...\"");
                    Console.ReadLine();
                    Console.WriteLine("Just as you open your mouth to ask about this fallen greatwood, the mysterious warlock melts into the darkness, nothing more than a wisp...");
                    Console.ReadLine();
                    Console.WriteLine("To be continued...");
                    break;
                }
                else
                {
                    if (AnswerNum > SecretNumber)
                    {
                        Console.WriteLine($"\"Do not toy with me, child, your number was too high! You have {DifficultySelection-i-1} guesses remaining...\"");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"\"Pathetic! Are you even trying? Your number is too low! You have {DifficultySelection-i-1} guesses remaining...\"");
                        Console.WriteLine();
                    }

                }
            }
        }
    }
}