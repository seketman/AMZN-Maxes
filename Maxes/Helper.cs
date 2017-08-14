using System;
using System.Diagnostics;
using System.Linq;

namespace Maxes
{
    public class Helper
    {
        public delegate int[] CounterType(int[] nums, int[] maxes);

        public static void RunCounter(CounterType method, int[] nums, int[] maxes, string caption)
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            var results = method(nums, maxes);
            stopWatch.Stop();

            var resultsStr = string.Join(",", results.Select(n => n.ToString()).ToArray());
            Console.WriteLine($"{caption}:\t[{resultsStr}] ({stopWatch.ElapsedTicks} ticks)");
        }
    }
}