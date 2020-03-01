using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_H_NRepeatedElementInSize2NArray
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 961. N-Repeated Element in Size 2N Array

        // In a array A of size 2N, there are N+1 unique elements, and exactly one of these elements is repeated N times.

        // Return the element repeated N times.

        // Example 1:
        // Input: [1,2,3,3]
        // Output: 3

        // Example 2:
        // Input: [2,1,2,5,3,2]
        // Output: 2

        // Example 3:
        // Input: [5,1,5,2,5,3,5,4]
        // Output: 5

        // Note:
        //  1. 4 <= A.length <= 10000
        //  2. 0 <= A[i] < 10000
        //  3. A.length is even



        // ---------------------------------------- My Solution ----------------------------------------
        public int RepeatedNTimes(int[] A)
        {
            var unique = new List<int>();

            foreach (int i in A)
            {
                if (!unique.Contains(i))
                {
                    unique.Add(i);
                }
                else
                {
                    return i;
                }
            }

            return -1;
        }
        // 120 ms <-- Beats 93.60%
        // Solved February 28, 2020



        // ---------------------------------------- 124 ms Solution on LeetCode ----------------------------------------
        // Used HashSet
        public int RepeatedNTimes124(int[] A)
        {
            var n2 = A.Length;
            var n = n2 / 2;
            var occurred = new HashSet<int>();
            foreach (var i in A)
            {
                if (!occurred.Add(i))
                {
                    return i;
                }
            }
            return -1;
        }



        // ---------------------------------------- 112 ms Solution on LeetCode ----------------------------------------
        public int RepeatedNTimes112(int[] A)
        {
            /*List<int> l = new List<int>();
            int a = 0;
            for(int i = 0; i < A.Length; i++)
            {
                if(l.Contains(A[i]))
                {
                    a = A[i];
                    break;
                }
                else
                    l.Add(A[i]);
            }
            return a;*/
            Dictionary<int, int> d = new Dictionary<int, int>();
            int a = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (d.ContainsKey(A[i]))
                {
                    a = A[i];
                    break;
                }
                else
                    d.Add(A[i], 1);
            }
            return a;
        }

    } // LC_H_NRepeatedElementsInSize2NArray class

} // CSharpPracticeExercises namespace

