using System.Text;

namespace Algorithms.Sessions
{
    public class Session1Practice
    {
        /// <summary>
        /// https://www.geeksforgeeks.org/problems/number-of-factors1435/1
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public int CountFactors(int N)
        {
            var count = 0;
            for (var i = 1; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    if (i * i == N)
                        count++;
                    else
                        count += 2;
                }
            }
            return count;
        }

        /// <summary>
        /// Rotate Array
        /// O(n) T; O(1) S
        /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/646/
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        public void Rotate(int[] nums, int k)
        {
            var n = nums.Length;
            while (k > 0)
            {
                var move = nums[n - 1];
                for (var i = n - 1; i > 0; i--)
                {
                    nums[i] = nums[i - 1];
                }
                nums[0] = move;
                k--;
            }
            
        }

        private int[] Reverse(int[] input, int startIndex, int endIndex)
        {
            var temp = input[startIndex];
            input[startIndex] = input[endIndex];
            input[endIndex] = temp;
            startIndex++;
            endIndex--;
            return input;
        }

        /// <summary>
        /// https://www.geeksforgeeks.org/problems/prime-number2314/1
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public int IsPrime(int N)
        {
            if (N == 1)
                return 0;

            for (var i = 2; i * i <= N; i++)
            {
                if (N % i == 0)
                    return 0;
            }

            return 1;
        }
    }
}
