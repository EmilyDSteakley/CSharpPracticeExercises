using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_A_TwoSum
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 1. Two Sum
        // Given an array of integers, return indices of the two numbers such that they add up to a specific target.

        // You may assume that each input would have exactly one solution, and you may not use the same element twice.

        // Example:
        // Given nums = [2, 7, 11, 15], target = 9,

        // Because nums[0] + nums[1] = 2 + 7 = 9,
        // return [0, 1].



        // ---------------------------------------- My Solution ----------------------------------------
        public int[] TwoSum(int[] nums, int target)
        {
            var ans = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        ans[0] = i;
                        ans[1] = j;
                        return ans;
                    }
                }
            }
            return ans;
        }
        // 388 ms <-- Beats 49.99%
        // Solved February 18, 2020



        // ---------------------------------------- 400 ms Solution on LeetCode ----------------------------------------

        public int[] TwoSum400(int[] nums, int target)
        {
            int i, j;
            int[] ans = new int[2];
            for (i = 0; i < nums.Length; i++)
            {
                for (j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        ans[0] = i;
                        ans[1] = j;
                        return ans;
                    }

                }
            }
            return ans;
        }



        // ---------------------------------------- 216 ms Solution on LeetCode ----------------------------------------

        public int[] TwoSum216(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2) return null;

            var len = nums.Length;
            var t = new Dictionary<int, int>(len / 2);

            for (int i = 0, c = 0; i < len - 1; i++)
            {
                if (i != 0 && t.TryGetValue(target - nums[i], out var j) && i != j) return new int[] { i, j };

                while (++c < len)
                    if (nums[c] + nums[i] == target) return new int[] { i, c };
                    else t[nums[c]] = c;
            }
            return null;
        }

    } // class TwoSum

} // namespace LeetCodeArrays
