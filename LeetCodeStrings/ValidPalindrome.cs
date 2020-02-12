using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeStrings
{
    class ValidPalindrome
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 125. Valid Palindrome
        // Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

        // Note: For the purpose of this problem, we define empty string as valid palindrome.

        // Example 1:
        // Input: "A man, a plan, a canal: Panama"
        // Output: true

        // Example 2:
        // Input: "race a car"
        // Output: false



        // ---------------------------------------- My Solution ----------------------------------------
        public bool IsPalindrome(string s)
        {
            var alpha = new string(s.Where(c => Char.IsLetter(c) || Char.IsNumber(c)).ToArray());
            var test = alpha.ToLower();

            if (s == "")
                return true;

            char[] chars = test.ToCharArray();
            for (int i = 0, j = chars.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }
            
            string newStr = new string(chars);
            return test == newStr;

            // 476 ms <-- Beats 85.75%
            // Solved February 11, 2020
        }

        // ---------------------------------------- 60 ms Solution on LeetCode ----------------------------------------
        public bool IsPalindrome60(string s)
        {
            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                //while(start<end && (s[start]<48 || s[start]>57 && s[start]<65 || (90 < s[start] && s[start] < 97) || s[start] > 122))
                while (start < end && (s[start] < '0' || s[start] > '9' && s[start] < 'A' || ('Z' < s[start] && s[start] < 'a') || s[start] > 'z'))
                    start++;
                while (end > start && (s[end] < 48 || s[end] > 57 && s[end] < 65 || (90 < s[end] && s[end] < 97) || s[end] > 122))
                    end--;
                if (Char.ToLower(s[start++]) != Char.ToLower(s[end--]))
                    return false;
            }
            return true;

        }
    }
}
