namespace Sorting
{
    public static partial class Sort
    {
        /// <summary>
        /// A comparison sort algorithm usually two or three times faster than
        /// <see cref="Sorting.Mergesort"/> or <see cref="Sorting.Heapsort"/>.
        /// Not fast when sorting sequentially accessed data, such as a linked list.
        /// </summary>
        /// <best>
        /// O(n) or O(n log n)
        /// </best>
        /// <worst>
        /// O(n^2)
        /// </worst>
        public static void Quicksort(this int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            Quicksort(array, 0, array.Length - 1);
        }

        private static void Quicksort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int p = Partition(array, low, high);
                Quicksort(array, low, p);
                Quicksort(array, p + 1, high);
            }
        }

        // Using Hoare partition scheme
        private static int Partition(int[] array, int low, int high)
        {
            var pivot = array[low];
            var i = low - 1;
            var j = high + 1;
            while (true)
            {
                do i++; while (array[i] < pivot);
                do j--; while (array[j] > pivot);
                if (i >= j)
                    return j;
                Swap(array, i, j);
            }
        }
    }
}