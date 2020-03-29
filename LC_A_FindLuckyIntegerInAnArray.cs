using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_A_FindLuckyIntegerInAnArray
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 1394. Find Lucky Integer in an Array

        // Given an array of integers arr, a lucky integer is an integer which has a frequency in the array equal to its value.

        // Return a lucky integer in the array. 
        // If there are multiple lucky integers return the largest of them.
        // If there is no lucky integer return -1.

        // Example 1:
        // Input: arr = [2,2,3,4]
        // Output: 2
        // Explanation: The only lucky number in the array is 2 because frequency[2] == 2.

        // Example 2:
        // Input: arr = [1,2,2,3,3,3]
        // Output: 3
        // Explanation: 1, 2 and 3 are all lucky numbers, return the largest of them.

        // Example 3:
        // Input: arr = [2, 2, 2, 3, 3]
        // Output: -1
        // Explanation: There are no lucky numbers in the array.

        // Example 4:
        // Input: arr = [5]
        // Output: -1

        // Example 5:
        // Input: arr = [7, 7, 7, 7, 7, 7, 7]
        // Output: 7

        // Constraints:
        //  - 1 <= arr.length <= 500
        //  - 1 <= arr[i] <= 500



        // ---------------------------------------- My Solution ----------------------------------------
        public int FindLucky(int[] arr)
        {
            var numbers = new Dictionary<int, int>();
            foreach (int num in arr)
                if (!numbers.ContainsKey(num))
                    numbers.Add(num, 1);
                else
                    numbers[num]++;

            var output = -1;
            foreach (KeyValuePair<int, int> freq in numbers)
                if (freq.Key == freq.Value && freq.Key > output)
                    output = freq.Key;

            return output;
        }
        // 148 ms
        // Solved March 28,, 2020

    } // LC_A_FindLuckyIntegerInAnArray class

} // CSharpPracticeExercises namespace
