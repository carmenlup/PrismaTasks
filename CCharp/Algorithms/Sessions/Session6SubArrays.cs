using System;
using System.Collections.Generic;
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
        /// </summary>
        /// <param name="array"></param>
        /// <param name="s"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public int[] PrintSubArrayIndex(int[] array, int s, int e)
        {
            var result = new int[e - s + 1];
            var count = 0;
            for (int i = s; i <= e; i++)
            {
                result[count] = array[i];
                count++;
            }

            return result;
        }

        /// <summary>
        /// Initial problem: print a subArray from index start to index end
        /// T.C -> O(n)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="s"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public int[] PrintSubArrayOfLengthFromStartIndex(int[] array, int s, int l)
        {
            var result = new int[] { };
            var end = l - s - 1;
            for (int i = s; i < end; i++)
                result[i] = array[i];
            return result;
        }



    }
}
