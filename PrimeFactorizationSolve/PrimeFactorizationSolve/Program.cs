using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorizationSolve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create Variables
            int a, b, c, i, n;
            //create arry list to insert all the prime values
            List<int> termsList = new List<int>();
            //ask user to enter integer value
            Console.WriteLine("Please enter an Integer Value: ");
            //change string into int value
            a = int.Parse(Console.ReadLine());
            //for loop to loop through to the end
            for (b = 2; b <= a; b++)
            {
                if (a % b == 0)
                {
                    int x = 0;
                    while (a % b == 0)
                    {
                        a /= b;
                        x++;
                        termsList.Add(b);
                    }
                    Console.WriteLine($"{b} is a prime factor {x} times!");
                }
            }
            // print the updated array
            foreach (var item in termsList)
            {
                Console.Write(item.ToString() + ",");
            }
            Console.WriteLine("are prime factorization " );
        }
    }
}