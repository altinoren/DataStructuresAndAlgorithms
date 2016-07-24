using System;

namespace Sorting
{
    public static partial class Sort
    {
        /// <summary>
        /// A comparison sort algorithm usually slower than but with a better worst case
        /// than <see cref="Sorting.Quicksort"/>,
        /// Not fast when sorting sequentially accessed data, such as a linked list.
        /// </summary>
        /// <best>
        /// O(n log n)
        /// </best>
        /// <worst>
        /// O(n log n)
        /// </worst>
        public static void Heapsort(this int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            // Build heap to make sure the largest value is at the root
            Heapify(array, array.Length);

            var end = array.Length - 1;
            while (end > 0)
            {
                Swap(array, end, 0);
                end--;
                SiftDown(array, 0, end);
            }
        }

        private static void Heapify(int[] array, int length)
        {
            var start = length / 2;
            while (start >= 0)
            {
                SiftDown(array, start, length - 1);
                start--;
            }
        }

        private static void SiftDown(int[] array, int start, int end)
        {
            var root = start;
            while (2*root <= end) // 2*root = left child
            {
                var child = 2*root;
                var swap = root;

                if (array[swap] < array[child])
                    swap = child;
                if (child + 1 <= end && array[swap] < array[child + 1])
                {
                    swap = child + 1;
                }
                if (swap == root)
                {
                    return;
                }
                else
                {
                    Swap(array, root, swap);
                    root = swap;
                }
            }
        }
    }
}