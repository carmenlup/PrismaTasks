using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algorithms.Sessions
{
    public class Session23Sorting
    {
        // find the smalest number that can be formed by re-aranging the digits of a given nums
        // return the nums in form of slalest number
        // problem in the class is related to sorting
        // however the problem may contain the contition of non zero elements leading

        /// <summary>
        /// Medium
        /// 2165. Smallest Value of the Rearranged Number
        /// Source: https://leetcode.com/problems/smallest-value-of-the-rearranged-number/description/
        /// Solution:
        ///     - create a frequency array - 10 length array that will contain the frequency of each digit
        ///     - loop through the array and reconstructt the number based by digits
        ///     - considering the negative / positive nummbers edge cases
        /// a) if the number is 0 return 0
        /// b) if the number is negative keep the sign and add the digits in descending order
        /// c) if the number is positive reconstruct the number as follow
        ///    - if the number contains 0, we will add the first non zero digit to the number   
        ///    - we will add the rest of the digits in ascending order        
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public long SmalestNumber(long num)
        {
            if (num == 0)
                return num;

            // check if the number is negative to keep the sign
            var isNegative = num < 0;
            num = Math.Abs(num);

            // create a frequency nums
            var frequency = new int[10];
            while (num > 0)
            {
                frequency[num % 10]++;
                num /= 10;
            }

            // reconstruct the number
            // initialize num with 0 as long
            num = 0;

            // -9 < -8
            if (isNegative)
            {
                for (var i = 9; i >= 0; i--)
                {
                    while (frequency[i] > 0)
                    {
                        num = num * 10 + i;
                        frequency[i]--;
                    }
                }
                // the result should be negative
                return -num;
            }

            
            if (frequency[0] > 0)
            {
                // k ientify the first non zero digit
                var k = 1;
                // for positive number we will add the first non zero digit
                // example 403025 -> 200345  
                while (frequency[k] == 0)
                {
                    k++;
                    continue;
                }
                num = k;
                frequency[k]--;
            }

            for (var i = 0; i < 10; i++)
            {
                while (frequency[i] > 0)
                {
                    num = num * 10 + i;
                    frequency[i]--;
                }
            }

            return num;
        }

        /// <summary>
        /// Q1: Smallest Value of the Re-arranged Number
        /// Example of input: arr = [1, 2, 4, 3, 1, 4, 5, 1, 2]
        /// Solution: Count Sort for negative and positice numbers
        ///     - create a frequency arryay
        ///     - loop throught the freqency arryay and replace the elements in the original nums
        ///       with the index of the frequency arryay
        ///     - keep counter for index of the original arryay
        ///     
        /// Remark: this solution will work only for positive numbers
        /// T.C = O(n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] SmalestNumberPositiveDigits(int[] array)
        {
            var frequency = new int[10];
            for (var i = 0; i < array.Length; i++)
            {
                frequency[array[i]]++;
            }

            var k = 0;
            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j < frequency[i]; j++)
                {
                    array[k] = i;
                    k++;
                }
            }

            return array;
        }

        /// <summary>
        /// Q2: Smalest Value of the Re-arranged Number
        /// Example of input: arr = [-2, 3, 8, 3, -1, 3]
        /// Solution: Count Sort for negative and positice numbers
        ///     - create a frequency nums: identify length of frequency array based on the max and min values
        ///         length = max - min + 1
        ///     - loop throught the freqency nums and replace the elements in the original nums
        ///       with the index of the frequency nums
        ///     - keep counter for index of the original nums
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] SmalestNumberWithNegative(int[] array)
        {
            var min = int.MaxValue;
            var max = int.MinValue;

            for (var i = 0; i < array.Length; i++)
            {
                min = Math.Min(min, array[i]);
                max = Math.Max(max, array[i]);
            }

            var n = max - min + 1;
            var frequency = new int[n];
            for (var i = 0; i < array.Length; i++)
            {
                frequency[array[i] - min]++;
            }

            var k = 0;
            for (var i = min; i <= max; i++)
            {
                for (var j = 0; j < frequency[i - min]; j++)
                {
                    array[k] = i;
                    k++;
                }
            }

            return array;
        }

        /// <summary>
        /// Q3
        /// Merge all email imbox in cronological order
        /// Solution:
        ///     - this problem is similar to merging 2 sorted arrays problem
        ///     - depending on the imput given the implementation may vary 
        ///     - 
        /// Practice similar at Source: https://leetcode.com/problems/merge-sorted-nums/
        /// T.C = O(num)
        /// S.C = O(1)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] MergeAllImboxEmails(int[] mailbox1, int[] mailbox2)
        {
            var m = mailbox1.Length;
            var n = mailbox2.Length;
            var merged = new int[m + n];

            var k = 0;
            var i = 0;
            var j = 0;

            while (i < m && j < n)
            {
                if (mailbox1[i] < mailbox2[j])
                {
                    merged[k] = mailbox1[i];
                    k++;
                    i++;
                }
                else
                {
                    merged[k] = mailbox2[j];
                    k++;
                    j++;
                }
            }

            while (i < m)
            {
                merged[k] = mailbox1[i];
                k++;
                i++;
            }

            while (j < n)
            {
                merged[k] = mailbox2[j];
                k++;
                j++;
            }

            return merged;
        }

        /// <summary>
        /// Given an nums where odd and even elements are sorted, sort the entire nums
        /// Practice similar Source: https://leetcode.com/problems/sort-nums-by-parity-ii/
        /// Solution: 
        ///     - we will crerate 2 lists for odd and even numbers
        ///     - we will use 2 pointers to iterate over the nums
        ///     - we will add the elements to the original nums in the order 
        /// T.C = O(n)
        /// S.C = O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] SortArray(int[] nums)
        {
            var odd = new List<int>();
            var even = new List<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                    even.Add(nums[i]);
                else
                    odd.Add(nums[i]);
            }

            var k = 0;
            var o = 0;
            var e = 0;
            while (o < odd.Count && e < even.Count)
            {
                // condition to change in letcode practice similar
                // if (k % 2 == 1)
                if (odd[o] < even[e])
                {
                    nums[k] = odd[o];
                    k++;
                    o++;
                }
                else
                {
                    nums[k] = even[e];
                    k++;
                    e++;
                }
            }

            while (o < odd.Count)
            {
                nums[k] = odd[o];
                k++;
                o++;
            }

            while (e < even.Count)
            {
                nums[k] = even[e];
                k++;
                e++;
            }

            return nums;
        }
    }
}
