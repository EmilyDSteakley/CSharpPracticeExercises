using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_S_ValidPalindromeII
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 680. Valid Palindrome II
        // Given a non-empty string s, you may delete at most one character. Judge whether you can make it a palindrome.

        // Example 1:
        // Input: "aba"
        // Output: True

        // Example 2:
        // Input: "abca"
        // Output: True
        // Explanation: You could delete the character 'c'.

        // Note:
        // 1. The string will only contain lowercase characters a-z.The maximum length of the string is 50000.



        // ---------------------------------------- My Solution ----------------------------------------
        public bool ValidPalindrome(string s)
        {
            int i = 0;
            var counter = 0;
            int failedI = 0;
            int failedEnd = 0;
            char origChar = 'a';

            while (i < s.Length / 2)
            {
                var end = s.Length - 1 - i;

                if ((s[i] != s[end]) && (counter == 0))
                {
                    if (s[i] == s[end - 1])
                    {
                        failedI = i;
                        failedEnd = end;
                        origChar = s[end];
                        s = s.Remove(end, 1);
                        counter++;
                        continue;
                    }
                    else if (s[i + 1] == s[end])
                    {
                        s = s.Remove(i, 1);
                        counter++;
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if ((s[i] != s[end]) && (counter == 1))
                {
                    i = failedI;
                    end = failedEnd;
                    s = s.Insert(failedEnd, origChar.ToString());

                    if (s[i + 1] == s[end])
                    {
                        s = s.Remove(i, 1);
                        counter++;
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if ((s[i] != s[end]) && (counter > 1))
                {
                    return false;
                }
                i += 1;
            }
            return true;
        }
        // 112 ms <-- Beats 21.94%
        // Solved February 18, 2020



        // ---------------------------------------- 96 ms Solution on LeetCode ----------------------------------------
        public bool ValidPalindrome96(string s)
        {
            if (s.Length <= 2)
            {
                return true;
            }

            return IsPalin(s, 0, s.Length - 1, false);
        }

        private bool IsPalin(string s, int l, int r, bool flag)
        {
            if (l >= r)
            {
                return true;
            }

            if (s[l] == s[r])
            {
                return IsPalin(s, l + 1, r - 1, flag);
            }
            else if (flag)
            {
                return false;
            }
            else
            {
                return IsPalin(s, l + 1, r, true) || IsPalin(s, l, r - 1, true);
            }
        }



        // ---------------------------------------- 76 ms Solution on LeetCode ----------------------------------------
        public bool ValidPalindrome76(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left <= right)
            {
                if (s[left] != s[right])
                {
                    return IsPalin(s, left + 1, right) || IsPalin(s, left, right - 1);
                }
                left++;
                right--;
            }
            return true;

        }

        private bool IsPalin(string s, int left, int right)
        {
            while (left <= right)
            {
                if (s[left++] != s[right--])
                {
                    return false;
                }
            }
            return true;

        }

    } // ValidPalindromeII class

} // LeetCodeStrings namespace
