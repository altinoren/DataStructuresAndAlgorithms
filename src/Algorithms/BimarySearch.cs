using System;

namespace src.Algorithms
{
    public static partial class Algorithm
    {
        /// <summary>
        /// Uses binary search to find given element's order in a given sorted array.
        /// </summary>
        public static long BinarySeach(this int[] array, int element)
        {
            if (array == null || array.Length == 0)
                return -1;
            long start = 0;
            long end = array.Length - 1;
            while (start <= end)
            {
                long mid = (start + end)/2;
                if (array[mid] == element)
                    return mid;
                if (element < array[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }
    }
}
