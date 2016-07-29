using System.Linq;
using src.Algorithms;
using Xunit;

namespace src.Tests.Algorithms
{
    public class MaximumSubArraySum
    {
        [Fact]
        public void Can_Calculate_MaximumSubArraySum()
        {
            var test = new[] { 2, -9, 5, 1, -4, 6, 0, -7, 8 };
            long expected = 9;

            var result = test.MaximumSubArraySum();

            Assert.True(expected == result);
        }
    }
}