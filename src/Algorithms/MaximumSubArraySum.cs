using System;

namespace src.Algorithms
{
    public static partial class Algorithm
    {
        /// <summary>
        /// Calculates maximum sum of contiguous sub array.
        /// </summary>
        public static long MaximumSubArraySum(this int[] array)
        {
            if (array == null || array.Length == 0)
                return 0;

            long maxHere = 0;
            long maxSoFar = 0;

            for (int i = 0; i < array.Length; i++)
            {
                maxHere = Math.Max(array[i], maxHere + array[i]);
                maxSoFar = Math.Max(maxSoFar, maxHere);
            }
            return maxSoFar;
        }
    }
}