using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_M_PowerOfTwo
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 231. Power of Two

        // Given an integer, write a function to determine if it is a power of two.

        // Example 1:
        // Input: 1
        // Output: true
        // Explanation: 2^0 = 1

        // Example 2:
        // Input: 16
        // Output: true
        // Explanation: 2^4 = 16

        // Example 3:
        // Input: 218
        // Output: false



        // ---------------------------------------- My Solution ----------------------------------------
        public bool IsPowerOfTwo(int n)
        {
            if (n == 0)
                return false;

            while (n % 2 == 0)
            {
                n /= 2;
            }

            if (n == 1)
                return true;

            return false;
        }
        // 36 ms <-- Beats 95.69%
        // Solved March 2, 2020



        // ---------------------------------------- 44 ms Solution on LeetCode ----------------------------------------
        public bool IsPowerOfTwo44(int n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }



        // ---------------------------------------- 28 ms Solution on LeetCode ----------------------------------------
        public bool IsPowerOfTwo28(int n)
        {
            return n > 0 && 2147483648 % n == 0;
        }

    } // LC_M_PowerOfTwo class

} // CSharpPracticeExercises namespace
