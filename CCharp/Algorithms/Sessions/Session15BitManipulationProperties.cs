using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sessions
{
    /// <summary>
    /// Bit Manipulation 1 - session Friday 29th Nov
    /// this class contains the implementation and applicability of bit manipulation 
    /// covered in class session
    /// </summary>
    public class Session15BitManipulationProperties
    {
        // set ith bit - use OR operator
        // clear ith bit - use AND operator
        // toggle ith bit - use XOR operator
        // update ith bit - clear ith bit and set ith bit
        // check if ith bit is set - use AND operator
        // check if ith bit is clear - use AND operator
        // clear all bits from MSB to ith bit - use AND operator
        // clear all bits from ith bit to 0 - use AND operator
        // set all bits from MSB to ith bit - use OR operator

        public int FindIthBit(int num, int i)
        {
            return (num & (1 << i)) != 0 ? 1 : 0;
        }

        /// <summary>
        /// Question 1: Given a number set ith bit and return the number obtained
        /// </summary>
        /// <param name="num"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public int SetIthBit(int num, int i)
        {
            num = (num | (1 << i));
            return num;
            // we can write this in one line
            // return num | (1 << i);
        }

        /// <summary>
        /// Question 2: Given a number toggle ith bit and return the number obtained
        /// </summary>
        /// <param name="num"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public int ToggleIthBit(int num, int i)
        {
            num = num ^ (1 << i);
            return num;
            // we can write this in one line
            // return num ^ (1 << i);
        }

        public int ClearIthBit(int num, int i)
        {
            return num & ~(1 << i);
        }

        public int CheckIthBit(int num, int i)
        {
            return num & (1 << i);
        }

        /// <summary>
        /// Using left whift + and operator
        /// this can giveoverflow exception?
        /// </summary>
        /// <param name="num"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool IsIthBitSet(int num, int i)
        {
            return (num & (1 << i)) != 0;
        }

        /// <summary>
        /// Using right shift + and operator
        /// </summary>
        /// <param name="num"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public int IsIthBitSetRightShift(int num, int i)
        {
            return (num >> i) & 1;
        }


        /// <summary>
        /// Count all set bits
        /// T.C = O(log n)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int CountAllSetBits(int num)
        {
            var count = 0;
            while (num > 0)
            {
                count += num & 1;
                num >>= 1;
            }

            return count;
        }

        public int CountOneBitsFor32Bit(int num)
        {
            var count = 0;
            for (var i = 0; i < 32; i++)
            {
                if ((num & (1 << i)) == 0)
                {
                    count++;
                }
                //num = num & (num - 1);
            }

            return count;
        }

        public int GenerateIntWithTheGivvenNumberOfBitsAZerosBOnesCZeros(int a, int b, int c)
        {
            var num = 0;
            //for (var i = 0; i < a; i++)
            //{
            //    num = num << 1;
            //}

            var bitNo = c;

            for (var i = 0; i < b; i++)
            {
                num = (num << 1) | 1;
                bitNo++;
            }

            //for (var i = 0; i < c; i++)
            //{
            //    num = num << 1;
            //}

            return num;
        }

        #region Single number problems - Classic approach
        /// <summary>
        /// /// Easy
        /// 136. Single Number
        /// Source: https://leetcode.com/problems/single-number/
        /// 
        /// This problem can be solved using bit manipulation
        /// However we will solve this problem in a classic way first
        /// and we will generalize it for clasic approach 
        /// then we will solve and thing about bit manipulation
        /// Solution 1: Brute force
        ///     - Sort the array to cave the same numbers together
        ///     - Loop through the array and check if the current number is equal to the next number
        ///     - If it is equal then continue the loop and check next pair of numbers
        /// T.C = O(n log n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int FindSingleNumberClasicApproach(int[] A)
        {
            Array.Sort(A);
            //for (var i = 0; i < A.Length; i = i + 2)
            //{
            //    for (var j = i + 1; j < A.Length - 1; j++)
            //    {
            //        if (A[i] == A[j])
            //        {
            //            break; 
            //        }
            //        return A[i];
            //    }
            //}

            // We don't need to have 2 loops. one loop is enough and check next element
            // this will reduce the time complexity
            for (var i = 0; i < A.Length - 1; i = i + 2)
            {
                if (A[i] == A[i + 1])
                {
                    continue;
                }
                return A[i];
            }

            return A[A.Length - 1];
        }

        /// <summary>
        /// Medium
        /// 137. Single Number II
        /// https://leetcode.com/problems/single-number-ii/description/
        /// 
        /// This is similar with the above problem  only that 3 numbers are repeated
        /// Solution 1: Brute force
        ///     - Sort the array to cave the same numbers together
        ///     - Loop through the array and check if the current number is equal to the third number
        ///     - If it is equal then continue the loop and check next 3 elements
        /// T.C = O(n log n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int SingleNumber2(int[] A)
        {
            Array.Sort(A);
            for (var i = 0; i < A.Length - 2; i = i + 3)
            {
                if (A[i] == A[i + 2])
                {
                    continue;
                }
                return A[i];
            }
            return A[A.Length - 1];
        }

        /// <summary>
        /// We can generalize the problem above.
        /// The above problems are a special case of the next problem:
        /// Given an array of integers, every element appears k (k > 1) times except for one, 
        /// which appears only once. Return the single number
        /// 
        /// T.C = O(n log n)
        /// S.C = O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int SingleNumberGeneralisation(int[] A, int k)
        {
            Array.Sort(A);
            for (var i = 0; i < A.Length - k + 1; i = i + k)
            {
                if (A[i] == A[i + k - 1])
                {
                    continue;
                }
                return A[i];
            }
            return A[A.Length - 1];
        }
        #endregion

        #region Single number problems - bit manipulation
        /// <summary>
        /// Easy
        /// 136. Single Number
        /// Source: https://leetcode.com/problems/single-number/
        /// Solution 1: Brut force approach
        ///     Sort the array and traverse the array and check if the current element is equal to the next element
        ///     T.C -> O(n log(n))
        ///     S.C -> O(1)
        /// Solution 2: Using hashset
        ///     Traverse the array and add the element to the hashset if it is not present
        ///     Hasset will have key = number and value = count
        ///     Traverse the Haset and return the element with count = 1
        ///     T.C -> O(n)
        ///     S.C -> O(n)
        /// Solution 3: Optimal Solution Using SOR operator
        ///     The next properties are used:
        ///     a ^ a = 0
        ///     comutativity a ^ b = b ^ a
        ///     asociativity a ^ b ^ c = a ^ (b ^ c) = (a ^ b) ^ c
        ///     a ^ 0 = a
        ///     We traverse the array once and based on properties of XOR double elements will
        ///     cancel each other and we will have the single element
        ///     T.C -> O(n)
        ///     S.C -> O(1)
        /// </summary>
        public int FindSingle(int[] input)
        {
            var res = 0;

            for (var i = 0; i < input.Length; i++)
            {
                res ^= input[i];
            }

            return res;
        }
        #endregion
    }
}
