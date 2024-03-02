using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sessions
{
    public class Session4PrefixSum
    {
        /// <summary>
        /// 303. Range Sum Query - Immutable ?
        /// T.C = O(N*Q)
        /// S.C = O(Q)
        /// </summary>
        /// <param name="input">N length array of integers</param>
        /// <param name="q">List of Q numbers of queries</param>
        /// <returns></returns>
        public List<long> SumRangeBruteForce(int[] input, int[][] q)
        {
            var result = new List<long>();
            for (int i = 0; i < q.Length; i++) // O(N)
            {
                var st = q[i][0];
                var end = q[i][1];

                // sum must be long to avoid StackOverflow exception
                long sum = 0;
                for (int j = st; j <= end; j++) // O(Q)
                {
                    sum += input[j];
                }
                result.Add(sum);
            }

            return result;
        }

        /// <summary>
        /// T.C = O(N + Q)
        /// S.C = O(N)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public List<long> SumRange(int[] input, int[][] q)
        {
            var result = new List<long>();

            // create prefix sum
            var pSum = new long[input.Length];
            pSum[0] = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                pSum[i] += pSum[i - 1] + input[i];
            }

            for (int i = 0; i < q.Length; i++) // O(N)
            {
                var st = q[i][0];
                var end = q[i][1];

                // sum must be long to avoid StackOverflow exception
                long sum = 0;
                if (st == 0)
                    sum = pSum[end];
                else
                {
                    sum = pSum[end] - pSum[st -1];
                }
                //for (int j = st; j <= end; j++) // O(Q)
                //{
                //    sum += input[j];
                //}
                result.Add(sum);
            }

            return result;
        }

        /// <summary>
        /// Problem: For an array of integer calculate sum from left and right and count
        ///          all that are equal
        /// Sol:
        ///     1. Calculate pSum
        ///     2. find leftSum and rightSum for each i
        ///     3. count if leftSum = rightSum
        ///
        /// T.C = O(N + N) = O(N)
        /// S.C = O(N)
        /// </summary>
        /// <param name="input">Integer array of length N</param>
        /// <returns></returns>
        public int Equilibrium(int[] input)
        {
            long[] pSum = new long[input.Length];
            var n = input.Length;
            pSum[0] = input[0];
            for (int i = 1; i < n; i++)
            {
                pSum[i] = pSum[i - 1] + input[i];
            }
            int count = 0;
            long left;
            long right;
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                    left = 0;
                else
                    left = pSum[i - 1];

                right = pSum[n -1] - input[i];

                if (left == right)
                    count++;
            }

            return count;
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<int> RangeSum(int[] input)
        {
            var result = new List<int>();
            return result;
        }
    }
}
