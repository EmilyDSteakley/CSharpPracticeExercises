using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_S_MinimumNumberOfFrogsCroaking
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 1419. Minimum Number of Frogs Croaking

        // Given the string croakOfFrogs, which represents a combination of the string "croak" from different frogs, 
        // that is, multiple frogs can croak at the same time, so multiple “croak” are mixed.
        // Return the minimum number of different frogs to finish all the croak in the given string.

        // A valid "croak" means a frog is printing 5 letters ‘c’, ’r’, ’o’, ’a’, ’k’ sequentially.
        // The frogs have to print all five letters to finish a croak. 
        // If the given string is not a combination of valid "croak" return -1.

        // Example 1:
        // Input: croakOfFrogs = "croakcroak"
        // Output: 1 
        // Explanation: One frog yelling "croak" twice.

        // Example 2:
        // Input: croakOfFrogs = "crcoakroak"
        // Output: 2 
        // Explanation: The minimum number of frogs is two.
        // The first frog could yell "crcoakroak".
        // The second frog could yell later "crcoakroak".

        // Example 3:
        // Input: croakOfFrogs = "croakcrook"
        // Output: -1
        // Explanation: The given string is an invalid combination of "croak" from different frogs.

        // Example 4:
        // Input: croakOfFrogs = "croakcroa"
        // Output: -1

        // Constraints:
        //  - 1 <= croakOfFrogs.length <= 10^5
        //  - All characters in the string are: 'c', 'r', 'o', 'a' or 'k'.



        // ---------------------------------------- My Solution ----------------------------------------
        public int MinNumberOfFrogs(string croakOfFrogs)
        {
            var croak = new char[] { 'c', 'r', 'o', 'a', 'k' };
            var frogs = 0;
            var croaks = new List<char[]>();
            foreach (char c in croakOfFrogs)
            {
                if (c == 'c')
                {
                    var temp = new char[] { 'c' };
                    croaks.Add(temp);
                    var fullCroak = false;
                    foreach (var k in croaks)
                        if (k[i] == 'k')
                            fullCroak = true;
                    if (fullCroak == true)
                        frogs++;
                }

            }
        }
        // XX ms <-- Beats XX.XX%
        // Solved April XX, 2020



        // ---------------------------------------- XXX ms Solution on LeetCode ----------------------------------------
    }
}
