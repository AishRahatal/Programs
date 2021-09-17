using System;
using System.Diagnostics;
using System.Threading;
using System.Linq;


namespace StopWatchproject
{
    class StopWatch
    {
        static void Main(string[] args)
        {
			Console.WriteLine(" Stop watch Program ");
			Console.WriteLine("----------------------------------");
			// Create new stopwatch
			Stopwatch stopwatch = new Stopwatch();

			// start sopwatch
			Console.WriteLine("Press enter to start stopwatch");
			stopwatch.Start();
            Console.ReadLine();
            Console.WriteLine();
			Console.WriteLine("Stop watch is running ....");

			
			for (int i = 0; i < 1000; i++)
			{
				Thread.Sleep(1);
			}

			// Stop stopwatch

			Console.WriteLine("\n\nPress enter to stop stopwatch");
			stopwatch.Stop();
			Console.ReadLine();
			Console.WriteLine();
			Console.WriteLine("----------------------------------");


			// printing time elapsed
			Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);

			Console.WriteLine("----------------------------------");


		}
	}
}
