using System;


namespace FizzBuzzProblem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                //Ask the Use for the Input
                Console.WriteLine("Please Enter the number between 1 to 100");
                string UserInput = Console.ReadLine();
                //Change the String Input into Number
                int ChangeNumber = Int32.Parse(UserInput);
                if (ChangeNumber <= 100)
                {
                    //Check whether that inputted number is divisible by both 3 and 5
                    if (ChangeNumber%3 == 0 && ChangeNumber%5 == 0)
                    {
                        Console.WriteLine("Fizz Buzz");
                    }
                    //Check whether that inputted number is divisible by 3 or not
                    else if (ChangeNumber%3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    //Check whether that inputted number is divisible by 5 or not
                    else if (ChangeNumber%5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    //Display number which is not divisible by 3 and 5
                    {
                        Console.WriteLine(ChangeNumber);
                    }
                }
                else
                {
                    Console.WriteLine("{0} is greater than 100",ChangeNumber);
                }
            }
        }
    }
}

