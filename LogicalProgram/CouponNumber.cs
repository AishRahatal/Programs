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
			int num = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("---------------------------------------------------------------------");
			//int get_coupon(int n);
			
			

			if (num >0)
			{
				int c = get_coupon(num);

			}
			else
			{
				Console.WriteLine("Please enter valid number") ;

			}


         	int get_coupon(int num) 
                 {

			Random random = new Random();
			int[] coupon=new int[num];
		
					  
					for (int i = 0; i < num; i++)
					{
						coupon[i] = random.Next(100000000); // generating coupon number
					}
					for (int i = 0; i < coupon.Length; i++)
					{
						Console.WriteLine("Random number " +(i+1) +" generated :" + coupon[i]); 
					}
						Console.WriteLine("------------------------------------------------------");
				        
				         
		           Console.WriteLine("Distinct coupon number:");

					for (int i = 0; i < num; i++) // checking coupon number is repeated 
					{
						bool is_repeated= false;
						for (int j = 0; j < i; j++)
						{
							if (coupon[i] == coupon[j])
							{
							  is_repeated = true;
								break;
							}
						}

						if (!is_repeated)
						{
							Console.Write("{0} ",coupon[i]); // printing destict numbers

						}
					}

					Console.WriteLine("\n------------------------------------------------------");
                             return 0;
		      }

			Console.ReadKey();


		}
	}
}
