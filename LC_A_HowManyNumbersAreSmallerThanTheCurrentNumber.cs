using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_A_HowManyNumbersAreSmallerThanTheCurrentNumber
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it. 
        // That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].

        // Return the answer in an array.

        // Example 1:
        // Input: nums = [8,1,2,2,3]
        // Output: [4,0,1,1,3]
        // Explanation: 
        // For nums[0] = 8 there exist four smaller numbers than it(1, 2, 2 and 3). 
        // For nums[1] = 1 does not exist any smaller number than it.
        // For nums[2]= 2 there exist one smaller number than it (1). 
        // For nums[3] = 2 there exist one smaller number than it(1). 
        // For nums[4] = 3 there exist three smaller numbers than it(1, 2 and 2).

        //Example 2:
        //Input: nums = [6,5,4,8]
        //Output: [2,1,0,3]

        //Example 3:
        //Input: nums = [7,7,7,7]
        //Output: [0,0,0,0]

        // Constraints
        //  - 2 <= nums.length <= 500
        //  - 0 <= nums[i] <= 100



        // ---------------------------------------- My Solution ----------------------------------------
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var output = new int[nums.Length];
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] < nums[i])
                        counter++;
                }
                output[i] = counter++;
                counter = 0;
            }
            return output;
        }
        // 260 ms <-- Beats 41.38%
        // Solved February 29, 2020



        // ---------------------------------------- 228 ms Solution on LeetCode ----------------------------------------
        public int[] SmallerNumbersThanCurrent228(int[] nums)
        {
            int max = nums.Max(n => n);
            var record = new int[max + 1];
            foreach (var num in nums)
                record[num]++;
            int[] smallerNums = new int[record.Length];
            for (int i = 1; i < smallerNums.Length; i++)
                smallerNums[i] = smallerNums[i - 1] + record[i - 1];
            for (int i = 0; i < nums.Length; i++)
                nums[i] = smallerNums[nums[i]];
            return nums;
        }

    } // LC_C_HowManyNumbersAreSmallerThanTheCurrentNumber class

} // CSharpPracticeExercises namespace
