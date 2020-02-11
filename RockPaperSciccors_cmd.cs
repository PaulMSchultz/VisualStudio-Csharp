using System;
using System.Linq;

namespace CSC205PaulSchultzAssignment1{

    public class Random
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Rock - Paper - Scissors!");

            int counter = 1;
            int UserSelection = 0;
            bool PlayAgain = true;
            int playerWins = 0;
            int aiWins = 0;
            int ties = 0;

            while (PlayAgain == true)
            {
                while (counter > 0)
                {
                    //ERROR HANDLING
                    var valid = false;
                    while (!valid)
                    {
                        Console.WriteLine("Please Enter 1 for Rock, 2 for Paper, or 3 for Scissors.");
                        var val = Console.ReadLine();
                        valid = !string.IsNullOrWhiteSpace(val) && val.All(c => c >= '0' && c <= '3');
                        if (!valid)
                        {
                            Console.WriteLine("Invalid Input...");
                        }
                        if (valid)
                        {
                            //Convert userinput to an INT for later use
                            int UserInput = Convert.ToInt32(val);
                            if (UserInput == 1 || UserInput == 2 || UserInput == 3)
                            {
                                Console.WriteLine("Are you sure you want to play ROCK?");
                                Console.WriteLine("Y or N?");
                                string answer = (Console.ReadLine().ToLower());                                
                                if (answer == "y")
                                {
                                    counter = 0;
                                    UserSelection = 1;
                                    break;
                                }
                                else
                                {
                                    counter++;
                                }
                            }                            
                        }
                    }
                }
                //Generate a random number between 1 and 3
                System.Random rnd = new System.Random();
                //assign the random number to R to compare it later...also create a bool for a while loop if the user wants to keep playing
                int R = rnd.Next(1, 4);
                //Comparing the random number to the user selection to see who wins...
                if (R == 1)
                {
                    Console.WriteLine("I Chose Rock.");
                    if (R == UserSelection)
                    {
                        Console.WriteLine("Rock VS Rock ... It's a Tie.");
                        ties++;
                    }
                    if (UserSelection == 2)
                    {
                        Console.WriteLine("Paper Covers Rock ... You WIN!");
                        playerWins++;
                    }
                    if (UserSelection == 3)
                    {
                        Console.WriteLine("Rock Crushes Scissors ... You LOSE :( ");
                        aiWins++;
                    }
                }
                if (R == 2)
                {
                    Console.WriteLine("I Chose Paper.");
                    if (R == UserSelection)
                    {
                        Console.WriteLine("Paper VS Paper ... It's a Tie.");
                        ties++;
                    }
                    if (UserSelection == 1)
                    {
                        Console.WriteLine("Paper Covers Rock ... You LOSE :( ");
                        aiWins++;
                    }
                    if (UserSelection == 3)
                    {
                        Console.WriteLine("Scissors Cut Paper ... You WIN!  ");
                        playerWins++;
                    }
                }
                if (R == 3)
                {
                    Console.WriteLine("I Chose Scissors.");
                    if (R == UserSelection)
                    {
                        Console.WriteLine("Scissors VS Scissors ... It's a Tie.");
                        ties++;
                    }
                    if (UserSelection == 2)
                    {
                        Console.WriteLine("Scissors Cuts Paper ... You LOSE :( ");
                        aiWins++;
                    }
                    if (UserSelection == 1)
                    {
                        Console.WriteLine("Rock Crushes Scissors ... You WIN!!! ");
                        playerWins++;
                    }
                }
                int counter2 = 0;
                while (counter2 < 1)
                {
                    Console.WriteLine("Play Again? Y or N ");
                    //added function .ToLower in order to get rid of excess capital Y code
                    string AgainAnswer = Console.ReadLine().ToLower();                    
                    if (AgainAnswer == "y")
                    {
                        counter = 1;
                        Console.WriteLine("Bring It On!!!");
                        PlayAgain = true;
                        break;
                    }                    
                    else if (AgainAnswer == "n")
                    {
                        Console.WriteLine($"Score was {playerWins} for Player and {aiWins} for AI");
                        Console.WriteLine("Goodbye...");
                        PlayAgain = false;
                        counter = 0;
                        counter2 = 1;
                        Environment.Exit(-1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input...");
                        counter = 1;
                        counter2 = 0;
                    }
                }
            }
        }
    }
}

