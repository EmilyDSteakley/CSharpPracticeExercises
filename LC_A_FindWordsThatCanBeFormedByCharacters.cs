using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_A_FindWordsThatCanBeFormedByCharacters
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 1160. Find Words That Can Be Formed by Characters

        // You are given an array of strings words and a string chars.
        // A string is good if it can be formed by characters from chars (each character can only be used once).
        // Return the sum of lengths of all good strings in words.

        // Example 1:
        // Input: words = ["cat","bt","hat","tree"], chars = "atach"
        // Output: 6
        // Explanation: The strings that can be formed are "cat" and "hat" so the answer is 3 + 3 = 6.

        // Example 2:
        // Input: words = ["hello","world","leetcode"], chars = "welldonehoneyr"
        // Output: 10
        // Explanation: The strings that can be formed are "hello" and "world" so the answer is 5 + 5 = 10.

        // Note:
        //  - 1 <= words.length <= 1000
        //  - 1 <= words[i].length, chars.length <= 100
        //  - All strings contain lowercase English letters only.



        // ---------------------------------------- My Solution ----------------------------------------
        public int CountCharacters(string[] words, string chars)
        {
            if (words.Length < 1 || words.Length > 1000 || chars.Length < 1 || chars.Length > 100)
                throw new ArgumentOutOfRangeException();

            var possible = new StringBuilder(chars, chars.Length);
            var sum = 0;

            foreach (string word in words)
            {
                for(int i = 0, j = 0; i < word.Length; i++)
                {
                    if (possible.ToString().Contains(word[i]))
                    {
                        possible.Remove(possible.ToString().IndexOf(word[i]), 1);
                        j++;
                    }
                    else
                    {
                        possible.Clear();
                        possible.Append(chars);
                        break;
                    }

                    if (j == word.Length)
                    {
                        sum += word.Length;
                        possible.Clear();
                        possible.Append(chars);
                    }
                }
            }

            return sum;
        }
        // 160 ms <-- Beats 48.13%
        // Solved March 5, 2020



        // ---------------------------------------- 92 ms Solution on LeetCode ----------------------------------------
        public int CountCharacters92(string[] words, string chars)
        {
            //translate the string of characters into a hashmap
            //we know the range of letters is 26 so we can use an int[] to store
            int[] letterCounts = new int[26];
            foreach (char c in chars) letterCounts[c - 'a']++;

            int count = 0;
            foreach (string word in words)
            {
                int i = 0;

                //for each letter in the word try to decrement
                //if any letter is missing a break will occur before i == Length
                for (; i < word.Length && letterCounts[word[i] - 'a'] > 0; i++)
                {
                    letterCounts[word[i] - 'a']--;
                }

                //increment a count if i reached the end of the word
                if (i == word.Length)
                    count += word.Length;

                //restore any characters that were decremented by looping up to i
                for (int j = 0; j < i; j++)
                {
                    letterCounts[word[j] - 'a']++;
                }
            }
            return count;
        }

    } // LC_A_FindWordsThatCanBeFormedByCharacters class

} // CSharpPracticeExercises namespace
