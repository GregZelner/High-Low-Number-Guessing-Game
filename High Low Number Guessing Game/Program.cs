using System;

namespace High_Low_Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
        
            /* Description: This game involves a secret number being chosen by the computer within a specific range(let’s say 1 - 100) and the player then tries to guess this number.If the number they guess is too low, the program will say “too low” and if it is too high it will reply with “too
 high”. The player wins when they guess the correct number.
 Tips: First thing to look at is generating a random number. Despite the language you choose,
most of the time a random number can be created using a random generator function or object.
.NET has the “Random” object and C++ has rand(). 
Once you have a random number chosen, ask the player for a guess.
Compare their guess to this random number chosen.An easy if statement can be used to see if
it is too high or too low.If they are equal, tell the player they win and restart the game.
Added Difficulty: Put a limit on how many wrong guesses they can have.Too many and the game ends with “You lose”.
            */



            /* var generator = new Random.();
             var randomNumber = generator.RandomNumber(5, 100);
             Console.WriteLine($"Random number between 5 and 100 is {randomNumber}");

                         */

            //Number Guessing Game Code BELOW

            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("Try to guess the correct number by entering a number from 1-100");
            int RandomNumber;
               RandomNumber = Random.Next();

            
          
            string UsersGuess = Console.ReadLine();
            Console.WriteLine("You wrote " + (UsersGuess));
            int ConvertedGuess = Convert.ToInt32(UsersGuess);


            if (ConvertedGuess = RandomNumber)
            {
                Console.WriteLine("Congratulations!!! You Have Won The Game!");
            }

            if (ConvertedGuess != RandomNumber)
            {
                Console.WriteLine("Please Try Again");
                string UsersGuess = Console.ReadLine();
                Console.WriteLine("You wrote " + (UsersGuess));
                int ConvertedGuess = Convert.ToInt32(UsersGuess);

                /*At this point, I should include an if loop that if Convert.ToInt32 = null/ false
                then Console.WriteLine("This is an invalid number please try again"); 
                and starts over at beginning of loop... Boolean? .Parsemethod
                
                */

                if (ConvertedGuess = RandomNumber)
                {
                    Console.WriteLine("Congratulations!!! You Have Won The Game!");
                }

                if (ConvertedGuess != RandomNumber)
                {
                    Console.WriteLine("Please Try Again");
                    string UsersGuess = Console.ReadLine();
                    Console.WriteLine("You wrote " + (UsersGuess));
                    int ConvertedGuess = Convert.ToInt32(UsersGuess);


                }

        
            
        }
    }
}
