using System;

namespace Sorting
{
    public static partial class Sort
    {
        /// <summary>
        /// A comparison sort algorithm with too slow for large data sets but handy for small sets.
        /// Additionally, it's online which means it can sort a list as it receives it, nice for buffers.
        /// </summary>
        /// <best>
        /// O(n)
        /// </best>
        /// <worst>
        /// O(n^2)
        /// </worst>
        public static void Insertionsort(this int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j - 1] > array[j])
                {
                    Swap(array, j, j-1);
                    j--;
                }
            }
        }
    }
}