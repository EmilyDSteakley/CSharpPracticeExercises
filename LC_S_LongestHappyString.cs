using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_S_LongestHappyString
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 1405. Longest Happy String

        // A string is called happy if it does not have any of the strings 'aaa', 'bbb' or 'ccc' as a substring.

        // Given three integers a, b and c, return any string s, which satisfies following conditions:
        //  - s is happy and longest possible.
        //  - s contains at most a occurrences of the letter 'a', at most b occurrences of the letter 'b' and at most c occurrences of the letter 'c'.
        //  - s will only contain 'a', 'b' and 'c' letters.

        // If there is no such string s return the empty string "".

        // Example 1:
        // Input: a = 1, b = 1, c = 7
        // Output: "ccaccbcc"
        // Explanation: "ccbccacc" would also be a correct answer.

        // Example 2:
        // Input: a = 2, b = 2, c = 1
        // Output: "aabbc"

        // Example 3:
        // Input: a = 7, b = 1, c = 0
        // Output: "aabaa"
        // Explanation: It's the only correct answer in this case.

        // Constraints:
        //  - 0 <= a, b, c <= 100
        //  - a + b + c > 0



        // ---------------------------------------- My Solution ----------------------------------------
        public string LongestDiverseString(int a, int b, int c)
        {
            var output = new StringBuilder();
            var chars = new[] { 'a', 'b', 'c' };
            var nums = new[] { a, b, c };
            Array.Sort(nums, chars);
            output.Append(chars[2], nums[2]);
            output.Append(chars[1], nums[1]);
            output.Append(chars[0], nums[0]);

            int right = output.Length - 1;
            int first = 0, second = 1, third = 2;
            while (third <= output.Length - 1)
            {
                if (output[first] == output[second] && output[second] == output[third])
                {
                    if (output[right] != output[third])
                    {
                        (output[third], output[right]) = (output[right], output[third]);
                        first++;
                        second++;
                        third++;
                        right--;
                    }
                    else
                    {
                        output.Remove(third, 1);
                        right--;
                    }
                }
                else
                {
                    first++;
                    second++;
                    third++;
                }
            }

            return output.ToString();
        }
        // XX ms <-- Beats XX.XX%
        // Solved March XX, 2020



        // ---------------------------------------- XXX ms Solution on LeetCode ----------------------------------------
    }
}
