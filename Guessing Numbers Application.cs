using System;


//namespace is a container for classes and functions.
namespace Guessing_Numbers_Application
{

    //Inside classes we could have functions and variables.
    class Program
    {

        //Entry Point of Method, void returns nothing,
        static void Main(string[] args)
        {
            //Guessing Numbers Game


            //Introduction to C#

            /*

            string name = "Jeyason Jeyaparan";

            int age = 35;


            //Start Here

            //How to print stuff 2 ways
            //1) Concatenation
            Console.WriteLine("Hello "+name+" is "+age);

            //Formatting
            //2)Formatting
            Console.WriteLine("Hello {0} is {1}",name,age);
            */

            //Get the app info
            GetAppInfo();

            GreetUser();


            while (true)
            {

                //Set correct number
                //int correctNumber = 7;

                //We want a random correct number so create a new Random object.
                Random random = new Random();


                //Creates a random number from 1 to 10.
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Guess a number.
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();

                    //Make sure that its a number.
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red,"Please use an actual number!");

                        //Keep going.
                        continue;

                    }

                    //Cast the int and put it in guess.
                    guess = Int32.Parse(input);

                    //If the guess is incorrect, inform the user that.
                    if (guess != correctNumber)
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again!");
                    }

                }

                //Print success message
                PrintColorMessage(ConsoleColor.Yellow, "You guessed the right number!");

                //Ask the user if he or she wants to play again.
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;

                }
                else if(answer == "N")
                {
                    return;
                }
                {
                    return;
                }

            }

        }
        static void GetAppInfo()
        {
            //Set app var
            string appName = "Guessing Number Application";
            string appVersion = "1.0.0";
            string appAuthor = "Jeyason Jeyaparan";

            //Change text colour in the console.
            Console.ForegroundColor = ConsoleColor.Blue;


            //Write out app information
            Console.WriteLine("{0}: Version: {1} by {2}", appName, appVersion, appAuthor);

            //Reset Color.
            Console.ResetColor();
        }
        static void GreetUser()
        {
            //Set text colour to Magenta
            Console.ForegroundColor = ConsoleColor.Magenta;

            //Get user info to create a greeting
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game ...", inputName);

            Console.ResetColor();
        }
        //Print color message
        static void PrintColorMessage(ConsoleColor color,string message)
        {
            //Turn colour to red.
            Console.ForegroundColor = color;

            //Tell user its not a number.
            Console.WriteLine(message);

            //Reset the text colour.
            Console.ResetColor();
        }
    }
}
