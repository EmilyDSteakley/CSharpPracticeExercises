using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeStrings
{
    class ReverseString
    {
        public static void ReverseStrings(char[] s)
        {
            // ---------------------------------------- Problem ----------------------------------------

            // 344. Reverse String
            // Write a function that reverses a string. The input string is given as an array of characters char[].

            // Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

            // You may assume all the characters consist of printable ascii characters.

            // Example 1:
            // Input: ["h","e","l","l","o"]
            // Output: ["o","l","l","e","h"]

            // Example 2:
            // Input: ["H","a","n","n","a","h"]
            // Output: ["h","a","n","n","a","H"]



            // ---------------------------------------- My Solution ----------------------------------------

            var a = s.Length - 1;

            for (int i = 0; i <= a; i++)
            {
                var temp = s[i];
                s[i] = s[a];
                s[a] = temp;
                a--;
            }
            Console.WriteLine(s);

            // 392 ms <-- Beats 45.34%
            // Solved February 10, 2020



            // ---------------------------------------- 348 ms Solution on LeetCode ----------------------------------------

            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                char c = s[i];
                s[i] = s[j];
                s[j] = c;
            }
        }
    }
}
