using System;
using System.Linq;
using Xunit;

namespace CICDNugetTest.Tests
{
    public class UselessMathTests
    {
        [Fact]
        public void SumArrayOfDoubleElements()
        {
            double[] input = new[] { 20, 30, 15.2, .3 };
            double expectedResult = input.Sum();

            var result = UselessMath.Sum(input);

            Assert.Equal(expectedResult, result);
        }
    }
}
