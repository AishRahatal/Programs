using System;

namespace EvenOdd
{
    class EvenOdd_Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Check Whether a Number is Even or Odd");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            float remainder = num % 2;
            Console.WriteLine("-------------------------------------");
            if (num > 0)
            {
                if (remainder == 0)
                {
                    Console.WriteLine(num + " is an Even nmber");

                }
                else
                {
                    Console.WriteLine(num + " is an Odd number");
                }
            }
            else
            {
                Console.WriteLine("Input is invalid ");

            }


        }
    }
}
