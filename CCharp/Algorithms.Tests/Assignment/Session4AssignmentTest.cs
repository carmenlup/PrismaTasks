using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Assignment;

namespace Algorithms.Tests.Assignment
{
    public class Session4AssignmentTest
    {
        [Theory]
        [InlineData(new int[] {1, 2, 3, 4}, new int[] {1, 3, 6, 10})]
        public void PrefixSumInPlace(int[] input, int[] expected)
        {
            var sut = new Session4Assignment();
            var actual = sut.PrefixSumInPlace(input);
            Assert.Equal(expected, actual);
        }
    }
}
