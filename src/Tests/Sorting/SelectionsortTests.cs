using System;
using System.Linq;
using Sorting;
using Xunit;

namespace Tests.Sorting
{
    public class SelectionsortTests
    {
        [Fact]
        public void Can_Sort_Small_Array()
        {
            var test = new int[] { 2, 4, 1, 7, 6, 5, 3 };
            var expected = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            test.Selectionsort();

            Assert.True(Enumerable.SequenceEqual(test, expected));
        }

        [Fact]
        public void Can_Sort_Large_Array()
        {
            var expected = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                expected[i] = i;
            }

            var random = new Random();
            var test = ((int[])expected.Clone()).OrderBy(x => random.Next()).ToArray();

            test.Selectionsort();

            Assert.True(Enumerable.SequenceEqual(test, expected));
        }
    }
}