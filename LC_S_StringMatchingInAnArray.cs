using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_S_StringMatchingInAnArray
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 1408. String Matching in an Array

        // Given an array of string words. Return all strings in words which is substring of another word in any order. 

        // String words[i] is substring of words[j], if can be obtained removing some characters to left and/or right side of words[j].

        // Example 1:
        // Input: words = ["mass", "as", "hero", "superhero"]
        // Output: ["as", "hero"]
        // Explanation: "as" is substring of "mass" and "hero" is substring of "superhero".
        // ["hero", "as"] is also a valid answer.

        // Example 2:
        // Input: words = ["leetcode", "et", "code"]
        // Output: ["et", "code"]
        // Explanation: "et", "code" are substring of "leetcode".

        // Example 3:
        // Input: words = ["blue", "green", "bu"]
        // Output: []

        // Constraints:
        //  - 1 <= words.length <= 100
        //  - 1 <= words[i].length <= 30
        //  - words[i] contains only lowercase English letters.
        //  - It's guaranteed that words[i] will be unique.

        //Console.WriteLine(string.Join(", ", StringMatching(new[] { "mass", "as", "hero", "superhero" })));
        //Console.WriteLine(string.Join(", ", StringMatching(new[] { "leetcode", "et", "code" })));
        //Console.WriteLine(string.Join(", ", StringMatching(new[] { "blue", "green", "bu" })));
        //Console.WriteLine(string.Join(", ", StringMatching(new[] { "leetcoder", "leetcode", "od", "hamlet", "am" })));



        // ---------------------------------------- My Solution ----------------------------------------
        public IList<string> StringMatching(string[] words)
        {
            var output = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].Contains(words[j]))
                    {
                        if (!output.Contains(words[j]))
                            output.Add(words[j]);
                    }
                    else if (words[j].Contains(words[i]))
                    {
                        if (!output.Contains(words[i]))
                            output.Add(words[i]);
                    }
                }
            }

            return output;
        }
        // 204 ms <-- Beats 97.42%
        // Solved April 11, 2020



        // ---------------------------------------- 228 ms Solution on LeetCode ----------------------------------------
        public IList<string> StringMatching228(string[] words)
        {
            words = words.AsEnumerable().OrderBy(w => w.Length).ToArray();
            var result = new List<string>();
            var n = words.Length;

            for (var i = 0; i < n - 1; i++)
            {
                for (var j = i + 1; j < n; j++)
                {
                    if (words[j].Contains(words[i]))
                    {
                        result.Add(words[i]);
                        break;
                    }
                }
            }
            return result.Distinct().ToList();
        }
    }
}
