﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMath
{
    class SubtractTheProductAndSumOfDigitsOfAnInteger
    {
        public static int SubtractProductAndSum(int n)
        {
            // ---------------------------------------- Problem ----------------------------------------
            // 1281. Subtract the Product and Sum of Digits of an Integer
            // Given an integer number n, return the difference between the product of its digits and the sum of its digits.

            // Example 1:
            // Input: n = 234
            // Output: 15
            // Explanation:
            // Product of digits = 2 * 3 * 4 = 24
            // Sum of digits = 2 + 3 + 4 = 9
            // Result = 24 - 9 = 15

            // Example 2:
            // Input: n = 4421
            // Output: 21
            // Explanation:
            // Product of digits = 4 * 4 * 2 * 1 = 32
            // Sum of digits = 4 + 4 + 2 + 1 = 11
            // Result = 32 - 11 = 21

            // Constraints:
            // 1 <= n <= 10 ^ 5



            // ---------------------------------------- My Solution ----------------------------------------

            // 1. Convert int to byte array
            var numbers = new Stack<byte>();

            for (; n > 0; n /= 10)
                numbers.Push(Convert.ToByte(n % 10));

            var nArray = numbers.ToArray();

            // 2. Calculate sum of bytes in array
            var sum = 0;
            foreach (byte b in nArray)
            {
                sum += b;
            }

            // 3. Calculate product of bytes in array
            var product = 1;
            foreach (byte b in nArray)
            {
                product *= b;
            }

            // 4. Calculate difference between product and sum
            var difference = product - sum;

            // 5. Return difference
            return difference;
        }
    }
}