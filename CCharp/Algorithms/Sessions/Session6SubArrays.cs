using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sessions
{
    public class Session6SubArrays
    {
        /// <summary>
        /// Initial problem: print a subArray from index start to index end
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="s"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public int[] PrintSubArrayIndex(int[] array, int s, int e)
        {
            var result = new int[e - s + 1];
            var idx = 0;
            for (int i = s; i <= e; i++)
            {
                result[idx] = array[i];
                idx++;
            }

            return result;
        }

        /// <summary>
        /// Initial problem: print a subArray from index start to index end
        /// T.C -> O(n)
        /// T.C -> O(1)+
        /// </summary>
        /// <param name="array"></param>
        /// <param name="s"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public int[] PrintSubArrayOfLengthLFromStartIndex(int[] array, int s, int l)
        {
            // l = end - s + 1 ->  length of interval 
            var end = l + s - 1;
            var result = new int[l];
            var idx = 0;
            for (int i = s; i <= end; i++)
            {
                result[idx] = array[i];
                idx++;
            }

            return result;
        }

        /// <summary>
        /// Problem count total sub-arrays of a given array
        /// Solution: brute force
        ///     - iterate over the array 2 times to count the sub-arrays
        /// T.C -> O(n)
        /// S.C -> O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int CountSubArraysOfAnArrayBruteForce(int[] input)
        {
            var count = 0;
            for (var i = 0; i < input.Length; i++)
            {
                for (var j = i; j < input.Length; j++)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Total sub-arrays of a given array
        /// Solution 2:
        ///     The problem can be solved in O(1) time complexity based on the next observation:
        ///     Example: arr[n] - n has n elements
        ///         - starting from index 0 we can construct n sub-arrays with 1, 2, 3, ... n elements
        ///         - starting to index 1 we can construct n - 1 sub-arrays with 1, 2, 3, ..., n-1 elements
        ///         - ...
        ///         - starting from index n - 1 (last index of the array) we can construct 1 sub-array of 1 element
        ///         => Total numbers of the possible sub-arrays will be: n + (n-1) + ... + 1 = n * (n + 1) / 2
        /// T.C = O(1)
        /// S.C = O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int CountSubArraysOfAnArray(int[] input)
        {
            var n = input.Length;
            return n * (n + 1) / 2;
        }

        /// <summary>
        /// Problem - Print all sub-arrays of an array
        /// T.C -> O(n^3)
        /// S.C -> O(n^2)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<List<int>> PrintAllSubArrays(int[] input)
        {
            var n = input.Length;
            var result = new List<List<int>>();
            for (var s = 0; s < n; s++)
            {
                
                var idx = 0;
                for (var e = s; e < input.Length; e++)
                {
                    var subArray = new List<int>();
                    for (int i = s; i <= e; i++)
                        subArray.Add(input[i]);

                    result.Add(subArray);
                }
            }

            return result;
        }

    }
}
