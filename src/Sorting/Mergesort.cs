using System;

namespace Sorting
{
    public static partial class Sort
    {
        /// <summary>
        /// A comparison sort algorithm usually slower than
        /// <see cref="Sorting.Quicksort"/> and less memory efficient
        /// than <see cref="Sorting.Heapsort"/>. Preferable when using on
        /// slw-to-access media, historically tape drives. Best when sorting
        /// a linked list, a sequentially accessed data structure.
        /// </summary>
        /// <best>
        /// O(n log n)
        /// </best>
        /// <worst>
        /// O(n log n)
        /// </worst>
        public static void Mergesort(this int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            TopDownSplitMerge(array, 0, array.Length,  new int[array.Length]);
        }

        private static void TopDownSplitMerge(int[] array, int begin, int end, int[] work)
        {
            if (end - begin < 2)
                return;

            int middle = (begin + end) / 2;
            TopDownSplitMerge(array, begin, middle, work);
            TopDownSplitMerge(array, middle, end, work);
            TopDownMerge(array, begin, middle, end, work);
            Array.Copy(work, begin, array, begin, end - begin);
        }

        private static void TopDownMerge(int[] array, int begin, int middle, int end, int[] work)
        {
            var i = begin;
            var j = middle;

            for (int k = begin; k < end; k++)
            {
                if (i < middle && (j >= end || array[i] <= array[j]))
                {
                    work[k] = array[i];
                    i++;
                }
                else
                {
                    work[k] = array[j];
                    j++;
                }
            }
        }
    }
}