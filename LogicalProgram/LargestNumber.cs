using System;

namespace Largestnumber
{
    class LargestNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Find the Largest Among Three Numbers");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Enter first number:");
            int fnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int snum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            int tnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------");

            if (fnum > 0 || snum > 0 || tnum > 0)
            {
                if (fnum > snum && fnum > tnum)
                {
                    Console.WriteLine("Largest NUmber = " + fnum);

                }
                else if (snum > fnum && snum > tnum)
                {

                    Console.WriteLine("Largest NUmber = " + snum);

                }
                else if (tnum > fnum && tnum > snum)
                {

                    Console.WriteLine("Largest NUmber = " + tnum);

                }

                else
                {
                    Console.WriteLine("All numbers are same ");

                }
                


            }
            else
            {
                Console.WriteLine("Input is invalid ");

            }


        }
    }
}

