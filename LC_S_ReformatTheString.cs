using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_S_ReformatTheString
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 1417. Reformat The String

        // Given alphanumeric string s. (Alphanumeric string is a string consisting of lowercase English letters and digits).

        // You have to find a permutation of the string where no letter is followed by another letter and no digit is followed by another digit.
        // That is, no two adjacent characters have the same type.

        // Return the reformatted string or return an empty string if it is impossible to reformat the string.

        // Example 1:
        // Input: s = "a0b1c2"
        // Output: "0a1b2c"
        // Explanation: No two adjacent characters have the same type in "0a1b2c". "a0b1c2", "0a1b2c", "0c2a1b" are also valid permutations.

        // Example 2:
        // Input: s = "leetcode"
        // Output: ""
        // Explanation: "leetcode" has only characters so we cannot separate them by digits.

        // Example 3:
        // Input: s = "1229857369"
        // Output: ""
        // Explanation: "1229857369" has only digits so we cannot separate them by characters.

        // Example 4:
        // Input: s = "covid2019"
        // Output: "c2o0v1i9d"

        // Example 5:
        // Input: s = "ab123"
        // Output: "1a2b3"

        // Constraints:
        //  - 1 <= s.length <= 500
        //  - s consists of only lowercase English letters and/or digits.



        // ---------------------------------------- My Solution ----------------------------------------
        public string Reformat(string s)
        {
            var letters = new List<char>();
            var digits = new List<char>();

            foreach (char c in s)
            {
                if (c < 97)
                    digits.Add(c);
                else
                    letters.Add(c);
            }

            if (Math.Abs(letters.Count - digits.Count) > 1)
                return "";

            var output = letters.Count > digits.Count ? Merge(letters, digits) : Merge(digits, letters);

            return output;
        }

        public string Merge(List<char> larger, List<char> smaller)
        {
            int i = 0;
            int pos = 1;
            while (smaller.Count > 0)
            {
                larger.Insert(pos, smaller[0]);
                pos += 2;
                smaller.RemoveAt(0);
            }

            return String.Join("", larger);
        }
        // 84 ms <-- Beats 98.06%
        // Solved April 22, 2020



        // ---------------------------------------- 80 ms Solution on LeetCode ----------------------------------------
        public string Reformat80(string s)
        {
            StringBuilder letter = new StringBuilder();
            StringBuilder digit = new StringBuilder();

            foreach (char c in s)
            {
                if (IsLetter(c))
                {
                    letter.Append(c);
                }
                else
                {
                    digit.Append(c);
                }
            }

            if (Math.Abs(letter.Length - digit.Length) > 1)
            {
                return "";
            }

            StringBuilder max = letter;
            StringBuilder min = digit;
            if (letter.Length < digit.Length)
            {
                max = digit;
                min = letter;
            }

            StringBuilder result = new StringBuilder();
            for (int i = 0, j = 0; i < max.Length; i++)
            {
                result.Append(max[i]);
                if (j < min.Length)
                {
                    result.Append(min[j]);
                    j++;
                }
            }

            return result.ToString();
        }

        public bool IsLetter(char c)
        {
            return c >= 'a' && c <= 'z';
        }
    }
}
