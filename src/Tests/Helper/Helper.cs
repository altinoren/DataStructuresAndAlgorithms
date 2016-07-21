using System;

namespace Tests.Helper
{
    public static class HelperMethods
    {
        /// <summary>
        /// Check to see if to arrays have the same items in the same order.
        /// Enumerable.SequenceEqual(array1, array2) in Linq.
        /// </summary>
        public static bool AreIdentical(int[] array1, int[] array2)
        {
            if((array1 == null && array2 != null) || (array2 == null && array1 != null))
                return false;
            if(array1.Length != array2.Length)
                return false;

            for (int i = 0; i < array1.Length; i++)
            {
                if(array1[i] != array2[i])
                    return false;
            }

            return true;
        }
    }
}