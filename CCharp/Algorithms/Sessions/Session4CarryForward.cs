using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sessions
{
    public class Session4CarryForward
    {
        /// <summary>
        /// Count number of pair in a array of char such as for a and d
        /// where a is the first chat and d the second
        /// T.C = O(n^2)
        /// S.C = O(1)
        /// </summary>
        /// <returns></returns>
        public int CountPairAAndDBruteForce(char[] chars)
        {
            var count = 0;
            for (var i = 0; i < chars.Length; i++)
            {
                
                if (chars[i] == 'a')
                {
                    for (var j = i + 1; j < chars.Length; j++)
                    {
                        if (chars[j] == 'g')
                            count++;
                    }
                }
            }
            
            return count;
        }

        /// <summary>
        /// Count number of pair in a array of char such as for a and d
        /// where a is the first chat and d the second
        /// T.C = O(n)
        /// </summary>
        /// <param name="chars"></param>
        /// <returns></returns>
        public int CountPairAAndDBack(char[] chars)
        {
            var countG = 0;
            var pairs = 0;
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                if (chars[i] == 'g')
                {
                    countG++;
                }
                else
                {
                    if (chars[i] == 'a')
                        pairs += countG;
                }
            }
            return pairs;
        }

        /// <summary>
        /// Count number of pair in a array of char such as for a and d
        /// where a is the first chat and d the second
        /// T.C = O(n)
        /// </summary>
        /// <param name="chars"></param>
        /// <returns></returns>
        public int CountPairAAndD(char[] chars)
        {
            var countA = 0;
            var pairs = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'a')
                    countA++;
                else
                {
                    if (chars[i] == 'g')
                        pairs += countA;
                }
            }
            
            return pairs;
        }

        /// <summary>
        /// Count all leaders in an array of integers
        /// An item is a leader if all numbers from right are less than the current number
        /// arr[0] is always 0
        /// T.C = O(n^2)
        /// S.C = O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int LeadersBruteForce(int[] input)
        {
            var count = 1;
            for (int i = 1; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    if (input[i] < input[j])
                        break;
                }

                count++;
            }

            return count;
        }

        /// <summary>
        /// Count all leaders in an array of integers
        /// An item is a leader if all numbers from right are less than the current number
        /// arr[0] is always 0
        /// T.C = O(n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<int> leaders(int[] a, int n)
        {
            var result = new List<int>();
            result.Add(a[n - 1]);
            var max = a[n - 1];

            for (int i = n - 1; i >= 0; i--)
            {
                //if (max > input[i])
                // continue;
                if (max < a[i])
                {
                    max = a[i];
                    result.Add(a[i]);
                }
            }
            result.Reverse();
            return result;
        }

    }
}
