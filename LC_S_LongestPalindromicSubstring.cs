using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_S_LongestPalindromicSubstring
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 5. Longest Palindromic Substring
        // Given a string s, find the longest palindromic substring in s.You may assume that the maximum length of s is 1000.

        // Example 1:
        // Input: "babad"
        // Output: "bab"
        // Note: "aba" is also a valid answer.

        // Example 2:
        // Input: "cbbd"
        // Output: "bb"



        // ---------------------------------------- My Solution ----------------------------------------
        public string LongestPalindrome(string s)
        {

            //// Old way to print an array
            //foreach (var i in numbers)
            //    Console.WriteLine(i);

            //// New way to print an array
            //Array.ForEach(numbers, Console.WriteLine);

            //// Print an array like Java
            //Console.WriteLine("[{0}]", string.Join(", ", numbers));



            //string S = "bababad";
            //int n = S.Length;
            //char[] arr = S.ToCharArray();

            //for (int i = 0; i < S.Length; i++)
            //{
            //    int lastIdx = Array.LastIndexOf(arr, arr[i]);

            //    if (i != lastIdx)
            //    {
            //        int origI = i;
            //        int origL = lastIdx;
            //        while ((lastIdx - i) > 1)
            //        {
            //            if ((arr[i + 1]) == (arr[lastIdx - 1]))
            //            {
            //                i += 1;
            //                lastIdx -= 1;
            //                Console.WriteLine($"i is {i}, lastIdx is {lastIdx}");
            //                continue;
            //            }
            //        }
            //        string palindrome = S.Substring(origI, (origL + 1));
            //        Console.WriteLine($"The palindrome is {palindrome}");
            //    }
            //    break;




                return "incomplete";

            //}
            // XXX ms <-- Beats XX.XX%
            // Solved February XX, 2020
        }


        // ---------------------------------------- XXX ms Solution on LeetCode ----------------------------------------






    } // LC_S_LongestPalindromicSubstring class

} // CSharpPracticeExercises namespace
