using System;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string name;
            int age;
            string number;
            int exitCode = 0;
            int userCode = 7;

            //Console.WriteLine("Enter your name:");
            //name = Console.ReadLine();

            //Console.WriteLine("Hello " + name + "!");

            //if(name == "Alice")
            //{
            //    Console.WriteLine("Welcome, Alice!");
            //}
            //else
            //{
            //    Console.WriteLine("You are not Alice.");
            //}

            //Console.WriteLine("How old are you?");
            //Int32.TryParse(Console.ReadLine(), out age);

            //int counter = 0;
            //while (counter < age)
            //{
            //    Console.WriteLine("You are older than " + counter + " year olds!");
            //    counter++;
            //        }

            while (userCode != exitCode) { // This while loop keeps running until the inputted usercode is the same as the exitcode, which is 0
                Console.WriteLine("What is your favorite number?");
                number = Console.ReadLine();
                if (Int32.TryParse(number, out int integerNumber)) // This outputs an integer value if the input is an integer, since the default Console.ReadLine() output is a string
                {
                    if(integerNumber % 2 == 0) // This checks if the inputted number is divisible by two, if it is then the number is an even number
                    {
                        Console.WriteLine("Your favorite number " + number + " is an even number!");

                    }
                    else
                    {
                        Console.WriteLine("Your favorite number " + number + " is an odd number!");
                    }
                }
                else // This takes care of any input that is not an integer
                {
                    Console.WriteLine("That doesn't seem like a number to me... Try again.");
                }

                Console.WriteLine("Would you like to continue? Input 0 to exit or any other number to continue."); // This is where the user can exit the loop if they input 0
                string playAgain = Console.ReadLine();

                if(Int32.TryParse(playAgain, out userCode)) // This checks if the user inputted an integer value and if that value is 0. If the value is 0 then the loop is broken and application stops. 
                {
                    if (userCode == 0)
                    {
                        Console.WriteLine("It was fun playing. See you later!"); // Console application exits since the usercode is the same as the exitcode
                    }
                    else 
                    {
                        Console.WriteLine("Sweet, let's play again!");
                    }
                }
                else // This line runs if the user input was not an integer
                {
                    Console.WriteLine("You must input a number, not a character or special symbol. Try again.");
                    userCode = 7; //This resets the value of userCode back to an int type preventing from an invalid data type while loop exit
                }
                
            }
            

        }
    }
}