using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_SO_MinimumSubsequenceInNonIncreasingOrder
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 1403. Minimum Subsequence in Non-Increasing Order

        // Given the array nums, obtain a subsequence of the array whose sum of elements is strictly greater than the sum of the non included elements in such subsequence. 

        // If there are multiple solutions, return the subsequence with minimum size and 
        // if there still exist multiple solutions, return the subsequence with the maximum total sum of all its elements. 
        // A subsequence of an array can be obtained by erasing some(possibly zero) elements from the array. 

        // Note that the solution with the given constraints is guaranteed to be unique. Also return the answer sorted in non - increasing order.

        // Example 1:
        // Input: nums = [4, 3, 10, 9, 8]
        // Output: [10, 9]
        // Explanation: The subsequences[10, 9] and[10, 8] are minimal such that the sum of their elements is strictly greater than the sum of elements not included, 
        // however, the subsequence[10, 9] has the maximum total sum of its elements. 

        // Example 2:
        // Input: nums = [4, 4, 7, 6, 7]
        // Output: [7, 7, 6]
        // Explanation: The subsequence[7, 7] has the sum of its elements equal to 14 which is not strictly greater than the sum of elements not included(14 = 4 + 4 + 6). 
        // Therefore, the subsequence[7, 6, 7] is the minimal satisfying the conditions.Note the subsequence has to returned in non - decreasing order.

        // Example 3:
        // Input: nums = [6]
        // Output: [6]

        // Constraints:
        //  - 1 <= nums.length <= 500
        //  - 1 <= nums[i] <= 100



        // ---------------------------------------- My Solution ----------------------------------------
        public IList<int> MinSubsequence(int[] nums)
        {
            var output = new List<int>();
            var total = 0;
            var subTotal = 0;

            foreach (int n in nums)
                total += n;

            Array.Sort(nums);
            var pos = nums.Length - 1;
            while (subTotal <= total)
            {
                output.Add(nums[pos]);
                total -= nums[pos];
                subTotal += nums[pos];
                pos--;
            }

            return output;
        }
        // 248 ms <-- Beats 79.35%
        // Solved April 4, 2020



        // ---------------------------------------- 236 ms Solution on LeetCode ----------------------------------------
        public IList<int> MinSubsequence236(int[] nums)
        {
            var res = new List<int>();
            var record = new int[nums.Max(num => num) + 1];
            foreach (var num in nums)
                record[num]++;
            int sum = nums.Sum(num => num);
            int subSum = 0;
            var enough = false;
            for (int i = record.Length - 1; i >= 0; i--)
            {
                if (enough)
                    break;
                if (record[i] == 0) continue;
                for (int j = 0; j < record[i]; j++)
                {
                    if (subSum > sum)
                    {
                        enough = true;
                        break;
                    }
                    res.Add(i);
                    subSum += i;
                    sum -= i;
                }
            }
            return res;
        }
    }
}
