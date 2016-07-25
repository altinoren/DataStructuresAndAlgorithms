using System.Linq;
using src.Algorithms;
using Xunit;

namespace src.Tests.Algorithms
{
    public class RotateTests
    {
        [Fact]
        public void Can_Rotate_Array()
        {
            var test = new[] {1, 3, 2, 4, 6, 5};
            var expected = new[] {6, 5, 1, 3, 2, 4};
            var times = 4;

            test.Rotate(times);

            Assert.True(Enumerable.SequenceEqual(test, expected));
        }
    }
}