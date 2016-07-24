namespace Sorting
{
    public static partial class Sort
    {
        private static void Swap(int[] array, int i, int j)
        {
            var bag = array[i];
            array[i] = array[j];
            array[j] = bag;
        }
    }
}