using System;

namespace Sorting
{
    public static partial class Sort
    {
        /// <summary>
        /// A comparison sort algorithm usually too slow (with O(n^2) average case performance) to be
        /// used on modern computers. Might be handy if the input is expected to be almost sorted.
        /// Implemented here for historical purposes.
        /// </summary>
        /// <best>
        /// O(n)
        /// </best>
        /// <worst>
        /// O(n^2)
        /// </worst>
        public static void Bubblesort(this int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            var n = array.Length;

            do
            {
                var n2 = 0;

                for (int i = 1; i < n; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        Swap(array, i - 1, i);
                        n2 = i;
                    }
                }
                n = n2;
            } while (n > 0);
        }
    }
}