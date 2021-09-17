using System;
using System.Collections.Generic;

namespace Coupon
{
    class CouponNumber
    {
        static void Main(string[] args)
        {


            Console.WriteLine(" Program to generate a distinct coupon number");
            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine("How many random numbers do you need to generate coupon number?:  ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------------------");
            //int get_coupon(int n);
            
            int c = get_coupon(n);

            if (n > 0 && n <= 9)
            {

                Console.WriteLine(" A distinct coupon number: " + c);

                Console.WriteLine("------------------------------------------------------");


            }
            else
            {
                Console.WriteLine("Please enter number between 0-9") ;

            }


            int get_coupon(int num)
            {

                Random random = new Random();
                int coupon;

                switch (num)
                {

                    case 1:

                        coupon = random.Next(10);
                        Console.WriteLine("Total random number reuired is 1");
                        Console.WriteLine("------------------------------------------------------");

                        return coupon;
                        break;
                    case 2:

                        coupon = random.Next(100);
                        Console.WriteLine("Total random number reuired is 2");
                        Console.WriteLine("------------------------------------------------------");

                        return coupon;
                        break;
                    case 3:

                        coupon = random.Next(1000);
                        Console.WriteLine("Total random number reuired is 3");
                        Console.WriteLine("------------------------------------------------------");

                        return coupon;
                        break;
                    case 4:

                        coupon = random.Next(10000);
                        Console.WriteLine("Total random number reuired is 4");
                        Console.WriteLine("------------------------------------------------------");

                        return coupon;
                        break;
                    case 5:

                        coupon = random.Next(100000);
                        Console.WriteLine("Total random number reuired is 5");
                        Console.WriteLine("------------------------------------------------------");

                        return coupon;
                        break;
                    case 6:
                        coupon = random.Next(1000000);
                        Console.WriteLine("Total random number reuired is 6");
                        Console.WriteLine("------------------------------------------------------");

                        return coupon;
                        break;
                    case 7:
                        coupon = random.Next(10000000);
                        Console.WriteLine("Total random number reuired is 7");
                        Console.WriteLine("------------------------------------------------------");

                        return coupon;
                        break;
                    case 8:
                        coupon = random.Next(100000000);
                        Console.WriteLine("Total random number reuired is 8");
                        Console.WriteLine("------------------------------------------------------");

                        return coupon;
                        break;
                    case 9:
                        coupon = random.Next(1000000000);
                        Console.WriteLine("Total random number reuired is 9");
                        Console.WriteLine("------------------------------------------------------");

                        return coupon;
                        break;


                }
                return 0;
            }




        }
    }
}
