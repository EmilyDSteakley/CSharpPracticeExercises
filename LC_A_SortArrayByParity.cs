using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_A_SortArrayByParity
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 905. Sort Array By Parity

        // Given an array A of non-negative integers, return an array consisting of all the even elements of A, followed by all the odd elements of A.

        // You may return any answer array that satisfies this condition.

        // Example 1:
        // Input: [3,1,2,4]
        // Output: [2,4,3,1]
        // The outputs [4,2,3,1], [2,4,1,3], and[4, 2, 1, 3] would also be accepted.

        // Note:

        // 1 <= A.length <= 5000
        // 0 <= A[i] <= 5000



        // ---------------------------------------- My Solution ----------------------------------------
        public int[] SortArrayByParity(int[] A)
        {
            int front = 0;
            int end = A.Length - 1;
            while (front < end)
            {
                if (!isEven(A[front]))
                {
                    if (isEven(A[end]))
                    {
                        (A[front], A[end]) = (A[end], A[front]);
                        front++;
                        end--;
                    }
                    else
                        end--;
                }
                else
                {
                    if (isEven(A[end]))
                        front++;
                    else
                        front++;
                        end--;
                }
            }
            return A;
        }

        public bool isEven(int num)
        {
            return num % 2 == 0;
        }
        // 248 ms <-- Beats 84.16%
        // Solved March 12, 2020



        public int[] SortArrayByParity2(int[] A)
        {
            int[] sortA = new int[A.Length];
            int even = 0;
            int odd = A.Length - 1;
            foreach (int n in A)
            {
                if (n % 2 == 0)
                    sortA[even++] = n;
                else
                    sortA[odd--] = n;
            }
            return sortA;
        }
        // 252 ms <-- Beats 65.84%
        // Solved March 12, 2020



        // ---------------------------------------- 232 ms Solution on LeetCode ----------------------------------------
        public int[] SortArrayByParity232(int[] A)
        {
            int[] resArray = new int[A.Length];
            int j = 0;
            int k = A.Length;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                    resArray[j++] = A[i];
                else
                    resArray[--k] = A[i];

            }
            return resArray;
        }
    }
}
