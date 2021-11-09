using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Logical_Program
{
    class Watch
    {
		public static void watch()
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			Console.WriteLine("Enter Number : ");
			for (int i = 0; i < 1000; i++)
			{
				Thread.Sleep(5);
			}
			stopwatch.Stop();
			Console.WriteLine("Last Time : {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
			Console.ReadLine();
		}
	}
}
