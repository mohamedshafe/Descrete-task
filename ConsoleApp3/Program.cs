// See https://aka.ms/new-console-template for more information
using System;

namespace PrimeNumberFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for the start and end of the range
            Console.Write("Enter the start of the range: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the end of the range: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            // Check each number in the range to see if it is prime
            for (int i = n1; i <= n2; i++)
            {
                

                // Check if the number is evenly divisible by any other number in the range
                int sum =0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        ++sum;
                        
                    }
                }

                // If the number is prime, print it to the console
                if (sum==2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
