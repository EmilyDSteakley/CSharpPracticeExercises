using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_S_LongPressedNames
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 925. Long Pressed Name

        // Your friend is typing his name into a keyboard. Sometimes, when typing a character c, 
        // the key might get long pressed, and the character will be typed 1 or more times.

        // You examine the typed characters of the keyboard. Return True if it is possible that it was 
        // your friends name, with some characters (possibly none) being long pressed.

        // Example 1:
        // Input: name = "alex", typed = "aaleex"
        // Output: true
        // Explanation: 'a' and 'e' in 'alex' were long pressed.

        // Example 2:
        // Input: name = "saeed", typed = "ssaaedd"
        // Output: false
        // Explanation: 'e' must have been pressed twice, but it wasn't in the typed output.

        // Example 3:
        // Input: name = "leelee", typed = "lleeelee"
        // Output: true

        // Example 4:
        // Input: name = "laiden", typed = "laiden"
        // Output: true
        // Explanation: It's not necessary to long press any character.

        // Note:
        //  1. name.length <= 1000
        //  2. typed.length <= 1000
        //  3. The characters of name and typed are lowercase letters.


        // ---------------------------------------- My Solution ----------------------------------------
        public bool IsLongPressedName(string name, string typed)
        {
            if (String.Compare(name, typed) == 0)
                return true;
            if (name.Length > typed.Length)
                return false;

            var input = new StringBuilder();
            char previous = '0';
            int i = 0, j = 0;
            while (i < name.Length && j < typed.Length)
            {
                if (name[i] == typed[j])
                {
                    input.Append(typed[j++]);
                    previous = name[i++];
                }
                else if(typed[j] == previous)
                    j++;
                else
                    return false;
            }
            return name == input.ToString();
        }
        // 100 ms <-- Beats 8.26%
        // Solved April 6, 2020



        // ---------------------------------------- 56 ms Solution on LeetCode ----------------------------------------
        public bool IsLongPressedName56(string name, string typed)
        {
            int i = 0;
            int j = 0;
            while (j < typed.Length)
            {
                if (i < name.Length && name[i] == typed[j])
                {
                    i++;
                    j++;
                }
                else if (i > 0 && name[i - 1] == typed[j])
                {
                    j++;
                }
                else
                {
                    return false;
                }
            }
            return i == name.Length;
        }

    } // LC_S_LongPressedNames

} // CSharpPracticeExercises namespace
