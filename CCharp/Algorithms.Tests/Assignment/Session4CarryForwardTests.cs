using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Sessions;

namespace Algorithms.Tests.Assignment
{
    public class Session4CarryForwardTests
    {
        [Theory]
        [InlineData(new[]{'a','d','g','a','g','a','g','f','g'}, 9)]
        public void CountPairAAndDBruteForce_Should_Return_NumberOfPair_OfAAndDInThisOrder(char[] chars, int expected)
        {
            var sut = new Session4CarryForward();
            var actual = sut.CountPairAAndDBruteForce(chars);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 'a', 'd', 'g', 'a', 'g', 'a', 'g', 'f', 'g' }, 9)]
        public void CountPairAAndDBack_Should_Return_NumberOfPair_OfAAndDInThisOrder(char[] chars, int expected)
        {
            var sut = new Session4CarryForward();
            var actual = sut.CountPairAAndDBack(chars);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 'a', 'd', 'g', 'a', 'g', 'a', 'g', 'f', 'g' }, 9)]
        public void CountPairAAndD_Should_Return_NumberOfPair_OfAAndDInThisOrder(char[] chars, int expected)
        {
            var sut = new Session4CarryForward();
            var actual = sut.CountPairAAndD(chars);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 16, 17, 4, 3, 5, 2 }, 6)]
        public void LeadersBruteForce_Should_Return_AllLeadersFromAnIntegerArray(int[] input, int expected)
        {
            var sut = new Session4CarryForward();
            var actual = sut.LeadersBruteForce(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 16, 17, 4, 3, 5, 2 }, 3)]
        [InlineData(new[] { 3, 2, 4, 5, 2, 7, -1, 15 }, 1)]
        public void Leaders_Should_Return_AllLeadersFromAnIntegerArray(int[] input, int expected)
        {
            var sut = new Session4CarryForward();
            var actual = sut.Leaders(input);
            Assert.Equal(expected, actual);
        }
    }
}
