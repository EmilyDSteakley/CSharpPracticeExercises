using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_A_FibonacciNumber
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 509. Fibonacci Number
        // The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, 
        // such that each number is the sum of the two preceding ones, starting from 0 and 1. That is,
        //      F(0) = 0,   F(1) = 1
        //      F(N) = F(N - 1) + F(N - 2), for N > 1.

        // Given N, calculate F(N).

        // Example 1:
        // Input: 2
        // Output: 1
        // Explanation: F(2) = F(1) + F(0) = 1 + 0 = 1.

        // Example 2:
        // Input: 3
        // Output: 2
        // Explanation: F(3) = F(2) + F(1) = 1 + 1 = 2.

        // Example 3:
        // Input: 4
        // Output: 3
        // Explanation: F(4) = F(3) + F(2) = 2 + 1 = 3.

        // Note:
        //  - 0 ≤ N ≤ 30.



        // ---------------------------------------- My Solution ----------------------------------------
        public int Fib1(int N)
        {
            // Option 1:

            int[] fibonacciArr = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040 };

            return fibonacciArr[N];
        }
        //36 ms < --Beats 95.71 %
        //Solved February 25, 2020;



        public int Fib2(int N)
        {
            // Option 2:

            if (N <= 1)
                return N;

            return Fib2(N - 1) + Fib2(N - 2);
        }
        // 56 ms <-- Beats 38.80%
        // Solved February 25, 2020



        // ---------------------------------------- 24 ms Solution on LeetCode ----------------------------------------
        public int Fib24(int N)
        {
            int before_1 = 0, before_2 = 1, total = 0;
            if (N == 1 || N == 2) return 1;
            for (int i = 1; i <= N; i++)
            {
                total = before_1 + before_2;
                before_2 = before_1;
                before_1 = total;
            }
            return total;
        }

    } // LC_A_FibonacciNumber

} // CSharpPracticeExercises namespace
