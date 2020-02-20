using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_M_FindNumbersWithEvenNumberOfDigits
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 1295. Find Numbers with Even Number of Digits
        // Given an array nums of integers, return how many of them contain an even number of digits.

        // Example 1:
        // Input: nums = [12, 345, 2, 6, 7896]
        // Output: 2
        // Explanation:
        // 12 contains 2 digits(even number of digits).
        // 345 contains 3 digits(odd number of digits).
        // 2 contains 1 digit(odd number of digits).
        // 6 contains 1 digit(odd number of digits).
        // 7896 contains 4 digits(even number of digits).
        // Therefore only 12 and 7896 contain an even number of digits.

        // Example 2:
        // Input: nums = [555, 901, 482, 1771]
        // Output: 1
        // Explanation:
        // Only 1771 contains an even number of digits.

        // Constraints:
        // 1 <= nums.length <= 500
        // 1 <= nums[i] <= 10 ^ 5



        // ---------------------------------------- My Solution ----------------------------------------
        public int FindNumbers(int[] nums)
        {
            // Steps
            // 1. Use foreach # in array, count and if %2 == 0, count++
            // 2. Return count

            byte count = 0;

            foreach(int number in nums)
            {
                byte digits = Convert.ToByte(Math.Floor(Math.Log10(number) + 1));
                if(digits%2 == 0)
                {
                    count++;
                }
            }

            return count;
        }

        // 84 ms <-- Beats 99.62%
        // Solved January 31, 2020



        // ---------------------------------------- 76 ms Solution on LeetCode ----------------------------------------
        public int FindNumbers76(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] == 100000) || (1000 <= nums[i] && nums[i] <= 9999) || (10 <= nums[i] && nums[i] <= 99))
                    count++;
            }
            return count;
        }
    }
}
