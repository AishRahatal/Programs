using System;

namespace prime
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to get Prime number");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Enter number to check if it is prime:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                if (num % 2 == 0 && num != 2)
                {
                    Console.WriteLine(num + " is a Not Prime number");

                }
                else
                {
                    Console.WriteLine(num + " is a Prime number");
                }
            }
            else
            {
                Console.WriteLine("Invalid Number");

            }

        }
    }
}
