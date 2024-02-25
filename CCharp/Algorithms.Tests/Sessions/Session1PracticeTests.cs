using Algorithms.Sessions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests.Sessions
{
    public class Session1PracticeTests
    {
        [Theory]
        [InlineData(5, 2)]
        [InlineData(25, 3)]
        [InlineData(6, 4)]
        public void CountFactors_Should_Return_TheTotalNumbersOfDivisors_ForANaturalNumber(int input, int expected)
        {
            var sut = new Session1Practice();
            var current = sut.CountFactors(input);
            Assert.Equal(expected, current);
        }

        [Fact]
        public void Rotate_ShouldRotateArray_WithKPosAtRight_ForKLowerThanN()
        {
            var sut = new Session1Practice();

            var inputArray = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var positions = 3;

            sut.Rotate(inputArray, positions);

            Assert.Equal(5, inputArray[0]);
            Assert.Equal(6, inputArray[1]);
            Assert.Equal(7, inputArray[2]);
            Assert.Equal(1, inputArray[3]);
        }

        [Theory]
        [InlineData(4, 0)]
        [InlineData(2, 1)]
        [InlineData(1, 0)]
        [InlineData(32, 0)]
        public void IsPrime_Should_Validate_ANaturalNumber(int input, int expected)
        {
            var sut = new Session1Practice();
            var current = sut.IsPrime(input);
            Assert.Equal(expected, current);
        }
    }
}
