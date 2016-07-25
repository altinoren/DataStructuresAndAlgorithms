using System;

namespace src.Algorithms
{
    public static partial class Algorithm
    {
        /// <summary>
        /// Rotates (or shift while rotating the end to the begining) members of an array for given number of times.
        /// Example: For 2, 1234 -> 2341 -> 3412
        /// 
        /// This algorithm has O(n) time complexity and O(1) space complexity.
        /// One alternative is rotating the array one by one for number of iterations given,
        /// which has O(n*iteration) time complexity and O(1) space complexity.
        /// Another alternative is using a temporary array, with has O(n) and O(iteration)
        /// time and space complexity respectively.
        /// </summary>
        public static void Rotate(this int[] array, int numberOfIterations)
        {
            if (numberOfIterations < 0)
                throw new ArgumentOutOfRangeException();
            if (numberOfIterations == 0 || numberOfIterations == array.Length)
                return;
            if (numberOfIterations > array.Length)
                numberOfIterations = numberOfIterations%array.Length;

            Array.Reverse(array, 0, numberOfIterations);
            Array.Reverse(array, numberOfIterations, array.Length - numberOfIterations);
            Array.Reverse(array);
        }
    }
}