using System;

namespace Sorting
{
    public static partial class Sort
    {
        /// <summary>
        /// A comparison sort algorithm with too slow overall performance - O(n^2).
        /// </summary>
        /// <best>
        /// O(n^2)
        /// </best>
        /// <worst>
        /// O(n^2)
        /// </worst>
        public static void Selectionsort(this int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            for (int j = 0; j < array.Length - 1; j++)
            {
                var min = j;
                for (int i = j + 1; i < array.Length; i++)
                {
                    if (array[i] < array[min])
                    {
                        min = i;
                    }
                }

                if (min != j)
                {
                    Swap(array, j, min);
                }
            }
        }
    }
}