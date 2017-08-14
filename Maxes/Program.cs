using System;
using System.Linq;

namespace Maxes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 10, 5, 4, 8 };
            int[] maxes = { 3, 1, 7, 8 };

            Console.WriteLine($"Input nums:\t[{string.Join(",", nums.Select(n => n.ToString()).ToArray())}]");
            Console.WriteLine($"Input maxes:\t[{string.Join(",", maxes.Select(n => n.ToString()).ToArray())}]");

            Helper.RunCounter(Counters.CountsBasic, nums, maxes, "CountsBasic");

            Helper.RunCounter(Counters.CountsWithNumsSorted, nums, maxes, "CountsWithNumsSorted");

            Console.Write("Press any key to exit... ");
            Console.ReadKey();
        }
    }
}
