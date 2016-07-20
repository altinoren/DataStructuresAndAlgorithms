using Tests.Helper;
using Sorting;
using Xunit;


namespace Tests.Sorting
{
    public class QuicksortTests
    {
        [Fact]
        public void Can_Sort_Small_Array()
        {
            var testArray = new int[] { 2, 3, 1 };
            var expectedArray = new int[] { 1, 2, 3 };

            testArray.Quicksort();

            Assert.True(HelperMethods.AreIdentical(testArray, expectedArray));
        }
    }
}