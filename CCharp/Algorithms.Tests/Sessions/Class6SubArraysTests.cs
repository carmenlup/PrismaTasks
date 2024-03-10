using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Sessions;

namespace Algorithms.Tests.Sessions
{
    public class Class6SubArraysTests
    {
        [Theory]
        [InlineData(new int[] {4, 1, 2, 3, -1, 6, 9, 8, 12}, 2, 4, new int[] {2, 3, -1})]
        [InlineData(new int[] { 4, 1, 2, 3, -1, 6, 9, 8, 12 }, 4, 7, new int[] { -1, 6, 9, 8 })]
        [InlineData(new int[] { 4, 1, 2, 3, -1, 6, 9, 8, 12 }, 1, 6, new int[] { 1, 2, 3, -1, 6, 9 })]

        public void PrintSubArrayIndex_ShouldReturn_SubArrayFromIndexLToS(int[] array, int indexL, int indexR,
            int[] expected)
        {
            var sut = new Session6SubArrays();
            var actual = sut.PrintSubArrayIndex(array, indexL, indexR);
            Assert.Equal(expected, actual);

        }
    }
}
