using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_M_PalindromeNumber
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 9. Palindrome Number
        // Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.

        // Example 1:
        // Input: 121
        // Output: true

        // Example 2:
        // Input: -121
        // Output: false
        // Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

        // Example 3:
        // Input: 10
        // Output: false
        // Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

        // Follow up:
        // Coud you solve it without converting the integer to a string?



        // ---------------------------------------- My Solution ----------------------------------------
        public bool IsPalindrome(int x)
        {
            int orig = x;
            int n = 0;

            while (x > 0)
            {
                n *= 10;
                n += x % 10;
                x /= 10;
            }

            return (orig == n);
        }
        // 52 ms <-- Beats 97.92%
        // Solved February 11, 2020



        // ---------------------------------------- 40 ms Solution on LeetCode ----------------------------------------
        public bool IsPalindrome40(int x)
        {

            int orig = x;
            if (x < 0) return false;
            else
            {
                int rev = 0;
                while (x != 0)
                {
                    int pop = x % 10;
                    x /= 10;
                    rev = rev * 10 + pop;
                }
                return (orig == rev);
            }
        }
    }
}
