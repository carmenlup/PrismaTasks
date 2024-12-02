using Algorithms.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTests.Course.Class
{
    public class Session15BitManipulationPropertiesTests
    {
        //[Theory]
        //[InlineData(14, 2, 1110)]
        //[InlineData(14, 3, 211)]
        //public void ConvertInBaseX_WillReturn_TheNumberInBaseX(int n, int x, int expected)
        //{
        //    var sut = new Session11BitManipulation();
        //    var result = sut.ConvertPositiveInBaseX(n, x);
        //    Assert.Equal(expected, result);
        //}
        private Session15BitManipulationProperties _sut;
        public Session15BitManipulationPropertiesTests()
        {
            _sut = new Session15BitManipulationProperties();
        }

        //[Theory]
        //[InlineData(11, 1)]
        //[InlineData(12, 0)]
        //public void LastSignificantBit_WillReturn_TheNumberInBaseX(int x, int expected)
        //{
        //    var sut = new Session11BitManipulation();
        //    var result = sut.LastSignificantBit(x);
        //    Assert.Equal(expected, result);
        //}

        //[Theory]
        //[InlineData(11, "Odd")]
        //[InlineData(12, "Even")]
        //public void CheckEvenNunberBit_WillReturn_TheNumberInBaseX(int x, string expected)
        //{
        //    var sut = new Session11BitManipulation();
        //    var result = sut.CheckEvenNunberBit(x);
        //    Assert.Equal(expected, result);
        //}

        [Theory]
        [InlineData(new[] { 1, 2, 3, 2, 5, 5, 1 }, 3)]
        public void FindSingleNumbertBruteForce_ShouldReturn_TheSingleNumber(int[] input, int expected)
        {
            var result = _sut.FindSingleNumberClasicApproach(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 0, 1, 0, 1, 0, 1, 99 }, 99)]
        [InlineData(new[] { 1, 1, 2, 2, 3, 2, 5, 5, 1, 5 }, 3)]
        public void SingleNumber2_ShouldReturn_TheSingleNumber(int[] input, int expected)
        {
            var result = _sut.SingleNumber2(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 11, 2, 5, 5, 1 }, 2, 11)]
        [InlineData(new[] { 0, 1, 0, 1, 0, 1, 99 }, 3, 99)]
        [InlineData(new[] { 1, 1, 2, 2, 3, 2, 5, 5, 1, 5, 1, 2, 5}, 4, 3)]
        public void SingleNumberGeneralisation_ShouldReturn_TheSingleNumber(int[] input, int k, int expected)
        {
            var result = _sut.SingleNumberGeneralisation(input, k);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 2, 2, 1 }, 1)]
        public void FindSingleNumber_ShouldReturn_TheSingleNumberInTheArray(int[] nums, int expected)
        {
            var result = _sut.FindSingle(nums);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 1, 0)]
        [InlineData(5, 0, 1)]
        public void FindIthBit_ShouldReturn_TheNumberWithIthBitSet(int n, int i, int expected)
        {
            var result = _sut.FindIthBit(n, i);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 1, 7)]
        [InlineData(45, 4, 61)]
        [InlineData(45, 2, 45)]
        public void SetIthBit_ShouldReturn_TheNumberWithIthBitSet(int n, int i, int expected)
        {
            var result = _sut.SetIthBit(n, i);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(45, 4, 61)]
        [InlineData(45, 2, 41)]
        public void ToggleIthBit_ShouldReturn_TheNumberWithIthBitToggled(int n, int i, int expected)
        {
            var result = _sut.ToggleIthBit(n, i);
            Assert.Equal(expected, result);
        }
    }
}
