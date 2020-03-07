using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_M_HappyNumber
    {
        // ---------------------------------------- Problem ----------------------------------------
        //202. Happy Number

        // Write an algorithm to determine if a number is "happy".

        // A happy number is a number defined by the following process: 
        // Starting with any positive integer, 
        // replace the number by the sum of the squares of its digits, 
        // and repeat the process until the number equals 1 (where it will stay), 
        // or it loops endlessly in a cycle which does not include 1. 
        // Those numbers for which this process ends in 1 are happy numbers.

        // Example: 
        // Input: 19
        // Output: true
        // Explanation: 
        // 12 + 92 = 82
        // 82 + 22 = 68
        // 62 + 82 = 100
        // 12 + 02 + 02 = 1



        // ---------------------------------------- My Solution ----------------------------------------
        public bool IsHappy(int n)
        {
            if (n <= 0)
            {
                return false;
            }

            int prod = n;
            int digit;
            var usedProd = new List<int>();

            while (prod != 1)
            {
                n = prod;
                prod = 0;
                while (n > 0)
                {
                    digit = n % 10;
                    prod += digit * digit;
                    n /= 10;
                }
                if (!usedProd.Contains(prod))
                    usedProd.Add(prod);
                else
                    return false;
            }
            return true;
        }
        // 40 ms <-- Beats 88.23%
        // Solved March 6, 2020



        // ---------------------------------------- 32 ms Solution on LeetCode ----------------------------------------
        public bool IsHappy32(int n)
        {
            int fast = n;
            int slow = n;
            while (true)
            {
                fast = Compute(Compute(fast));
                slow = Compute(slow);
                if (fast == 1 || slow == 1)
                {
                    return true;
                }
                if (fast == slow)
                {
                    return false;
                }
            }
        }
        public int Compute(int k)
        {
            int sum = 0;
            while (k != 0)
            {
                sum = sum + ((k % 10) * (k % 10));
                k = k / 10;
            }
            return sum;
        }

    } // LC_M_HappyNumber class

} // CSharpPracticeExercises namespace
