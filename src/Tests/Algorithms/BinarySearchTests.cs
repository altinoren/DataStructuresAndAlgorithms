using System.Linq;
using src.Algorithms;
using Xunit;

namespace src.Tests.Algorithms
{
    public class BinarySearchTests
    {
        [Fact]
        public void Can_Search_In_Array()
        {
            var test = new[] {1,4,6,8,9,12,55,78,90};
            var expected = 2l;
            var element = 6;

            var result = test.BinarySeach(element);

            Assert.True(expected == result);
        }
    }
}