namespace Sorting
{
    public static partial class Sort
    {
        /// <summary>
        /// A comparison sort algorithm usually two or three times faster than
        /// <see cref="Sorting.Mergesort"/> or <see cref="Sorting.Heapsort"/>
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
                Quicksort(array, low, p - 1);
                Quicksort(array, p + 1, high);
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            var pivot = array[high];
            var i = low;
            for (int j = low; j < high -1; j++)
            {
                if (array[j] <= pivot)
                {
                    Swap(array, i, j);
                    i++;
                }
            }
            Swap(array, i, high);
            return i;
        }

        private static void Swap(int[] array, int i, int j)
        {
            var bag = array[i];
            array[i] = array[j];
            array[j] = bag;
        }
    }
}