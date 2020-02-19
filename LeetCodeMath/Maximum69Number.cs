using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMath
{
    class Maximum69Number
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 1323. Maximum 69 Number
        // Given a positive integer num consisting only of digits 6 and 9.
        // Return the maximum number you can get by changing at most one digit(6 becomes 9, and 9 becomes 6).

        // Example 1:
        // Input: num = 9669
        // Output: 9969
        // Explanation:
        // Changing the first digit results in 6669.
        // Changing the second digit results in 9969.
        // Changing the third digit results in 9699.
        // Changing the fourth digit results in 9666.
        // The maximum number is 9969.

        // Example 2:
        // Input: num = 9996
        // Output: 9999
        // Explanation: Changing the last digit 6 to 9 results in the maximum number.

        // Example 3:
        // Input: num = 9999
        // Output: 9999
        // Explanation: It is better not to apply any change.

        // Constraints:
        // 1 <= num <= 10 ^ 4
        // num's digits are 6 or 9.



        // ---------------------------------------- My Solution ----------------------------------------
        public int Max69Number(int num)
        {
            string numStr = num.ToString();
            var numArr = new int[numStr.Length];
            var pos = numStr.Length - 1;
            int digit;
            
            while (num > 0)
            {
                digit = num % 10;
                numArr[pos] = digit;
                num /= 10;
                pos--;
            }

            for (int i = 0; i < numArr.Length; i++)
            {
                if (numArr[i] == 6)
                {
                    numArr[i] = 9;
                    return Convert.ToInt32(string.Join("", numArr));
                }
            }
            return Convert.ToInt32(string.Join("", numArr));
        }
        // 44 ms <-- Beats 35.46%
        // Solved February 19, 2020



        // ---------------------------------------- 40 ms Solution on LeetCode ----------------------------------------
        public int Maximum69Number40(int num)
        {
            StringBuilder sb = new StringBuilder(num.ToString());

            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '6')
                {
                    sb[i] = '9';
                    break;
                }
            }
            return Int32.Parse(sb.ToString());
        }



        // ---------------------------------------- 28 ms Solution on LeetCode ----------------------------------------
        public int Maximum69Number28(int num)
        {
            // znajdę pierwszą 6 od lewej i zamienię na 9.
            string num2 = num.ToString();
            int pierwsza6 = num2.IndexOf('6');
            if (pierwsza6 >= 0)
                num2 = num2.Remove(pierwsza6, 1).Insert(pierwsza6, "9");
            return int.Parse(num2);
        }
    }
}
