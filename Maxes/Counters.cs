using System;

namespace Maxes
{
    public static class Counters
    {
        public static int[] CountsBasic(int[] nums, int[] maxes)
        {
            var results = new int[maxes.Length];

            for (int x = 0; x < maxes.Length; x++)
            {
                int count = 0;
                for (int y = 0; y < nums.Length; y++)
                {
                    if (nums[y] <= maxes[x])
                    {
                        count++;
                    }
                }

                results[x] = count;
            }

            return results;
        }

        public static int[] CountsWithNumsSorted(int[] nums, int[] maxes)
        {
            var results = new int[maxes.Length];

            Array.Sort(nums);
            for (int x = 0; x < maxes.Length; x++)
            {
                int y = 0;
                while (y < nums.Length && nums[y] <= maxes[x])
                    y++;

                results[x] = y;
            }

            return results;
        }
    }
}
