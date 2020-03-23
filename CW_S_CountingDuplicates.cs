using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class CW_S_CountingDuplicates
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Counting Duplicates

        // Count the number of Duplicates

        // Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. 
        // The input string can be assumed to contain only alphabets(both uppercase and lowercase) and numeric digits.

        // Example
        // "abcde" -> 0 # no characters repeats more than once
        // "aabbcde" -> 2 # 'a' and 'b'
        // "aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
        // "indivisibility" -> 1 # 'i' occurs six times
        // "Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
        // "aA11" -> 2 # 'a' and '1'
        // "ABBA" -> 2 # 'A' and 'B' each occur twice



        // ---------------------------------------- My Solution ----------------------------------------
        public int DuplicateCount(string str)
        {
            var distinct = new List<char>();
            var duplicate = new List<char>();
            foreach (char c in str)
            {
                if (!distinct.Contains(char.ToLower(c)))
                    distinct.Add(char.ToLower(c));
                else if (!duplicate.Contains(char.ToLower(c)))
                    duplicate.Add(char.ToLower(c));
            }
            return duplicate.Count;
        }
        // Solved March 23, 2020



        // ---------------------------------------- Best Practices Solution on Codewars ----------------------------------------
        public static int DuplicateCountBest(string str)
        {
            return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
        }

    } // CW_S_CountingDuplicates class

} // CSharpPracticeExercises namespace
