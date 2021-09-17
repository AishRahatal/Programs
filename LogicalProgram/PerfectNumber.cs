using System;

namespace perfect_number
{
    class PerfectNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to get perfect");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Enter number to check if it is perfect:");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum=0;
            int i;
            if (num > 0)
            {
                Console.WriteLine("Factors of  " + num);

                for (i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {

                        sum = sum + i;

                        Console.Write("{0}  ", i);
                    }
                }

                Console.WriteLine("\n----------------------------------");

                Console.WriteLine("Sum of factors of " + num + " = " + sum);
                Console.WriteLine("----------------------------------");

                if (sum == num)
                {
                    Console.WriteLine(num + "  Number is a perfect number");

                }
                else
                {
                    Console.WriteLine(num + "  Number is not a perfect number");

                }
            }
            else
            {
                Console.WriteLine("Invalid Number");

            }
        }
    }
}
