using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_S_NumberOfStepsToReduceANumberInBinaryRepresentationToOne
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 1404. Number of Steps to Reduce a Number in Binary Representation to One

        // Given a number s in their binary representation. 
        // Return the number of steps to reduce it to 1 under the following rules:
        //  - If the current number is even, you have to divide it by 2.
        //  - If the current number is odd, you have to add 1 to it.

        // It's guaranteed that you can always reach to one for all testcases.

        // Example 1:
        // Input: s = "1101"
        // Output: 6
        // Explanation: "1101" corressponds to number 13 in their decimal representation.
        //  Step 1) 13 is odd, add 1 and obtain 14.
        //  Step 2) 14 is even, divide by 2 and obtain 7.
        //  Step 3) 7 is odd, add 1 and obtain 8.
        //  Step 4) 8 is even, divide by 2 and obtain 4.
        //  Step 5) 4 is even, divide by 2 and obtain 2.
        //  Step 6) 2 is even, divide by 2 and obtain 1.

        // Example 2:
        // Input: s = "10"
        // Output: 1
        // Explanation: "10" corressponds to number 2 in their decimal representation.
        //  Step 1) 2 is even, divide by 2 and obtain 1.

        // Example 3:
        // Input: s = "1"
        // Output: 0

        // Constraints:
        //  - 1 <= s.length <= 500
        //  - s consists of characters '0' or '1'
        //  - s[0] == '1'



        // ---------------------------------------- My Solution ----------------------------------------
        public int NumSteps(string s)
        {
            BigInteger num = 0;
            var power = 0;
            for (int i = s.Length - 1; i >= 0; i--)
                num += (BigInteger)(Char.GetNumericValue(s[i]) * Math.Pow(2, power++));

            //Console.WriteLine(num);

            var steps = 0;
            while (num != 1)
            {
                if (num % 2 == 0)
                    num /= 2;
                else
                    num += 1;

                steps++;
            }

            return steps;
        }
        // 80 ms <-- Beats 78.82%
        // Solved April 4, 2020



        // ---------------------------------------- 64 ms Solution on LeetCode ----------------------------------------
        public int NumSteps64(string s)
        {
            if (s.Length == 1)
                return 0;
            var steps = 0;
            var oldOne = 0;
            var oldOneReal = 0;
            var onePos = 0;
            var zeroPos = s.Length;
            var zeroPosReal = s.Length;
            var length = s.Length;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '1')
                {
                    onePos = i;
                    break;
                }
            }


            while (length != 1)
            {
                while (zeroPosReal > 0)
                {
                    zeroPosReal--;
                    if (s[zeroPosReal] == '0')
                    {
                        zeroPos = zeroPosReal;
                        break;
                    }


                }

                if (s[zeroPosReal] != '0')
                {
                    steps++;
                    steps += length - oldOne;
                    break;
                }
                else if (zeroPos < onePos)
                {
                    steps++;
                    var shift = onePos - zeroPos;
                    steps += shift;
                    length -= shift;
                    onePos = length - 1;
                    //oldOne += shift - shift;
                    oldOneReal += shift;

                }
                else if (onePos < zeroPos)
                {
                    var shift = length - 1 - onePos;
                    steps += shift;
                    //oldOne += shift;
                    length -= shift;
                    onePos = length - 1;
                    oldOneReal += shift;

                }

            }

            return steps;
        }
    }
}
