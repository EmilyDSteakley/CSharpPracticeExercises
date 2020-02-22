using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_A_FindNUniqueIntegersSumUpToZero
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 1204. Find N Unique Integers Sum up to Zero
        // Given an integer n, return any array containing n unique integers such that they add up to 0.

        // Example 1:
        // Input: n = 5
        // Output: [-7,-1,1,3,4]
        // Explanation: These arrays also are accepted[-5, -1, 1, 2, 3] , [-3,-1,2,-2,4].

        // Example 2:
        // Input: n = 3
        // Output: [-1,0,1]

        // Example 3:
        // Input: n = 1
        // Output: [0]

        // Constraints:
        // 1 <= n <= 1000      



        // ---------------------------------------- My Solution ----------------------------------------
        public int[] SumZero(int n)
        {
            var output = new int[n];
            int x = n / 2;
            int counter = 0;

            if (n % 2 == 0)
            {
                for (int i = n; i > 0; i--)
                {
                    if (x != 0)
                    {
                        output[counter] = x;
                        counter++;
                    }
                    else
                    {
                        i++;
                    }
                    x--;
                }
            }

            if (n % 2 == 1)
            {
                for (int i = n; i > 0; i--)
                {
                    output[counter] = x;
                    counter++;
                    x--;
                }
            }

            return output;

        }
        // 204 ms <-- Beats 82.18%
        // Solved February 22, 2020


        // ---------------------------------------- 188 ms Solution on LeetCode ----------------------------------------
        public int[] SumZero188(int n)
        {
            if (n == 1) return new[] { 0 };

            var ints = new int[n];
            for (int i = 0, val = 1; i < n / 2; i++, val++)
            {
                var index = i * 2;
                ints[index] = val;
                ints[index + 1] = -val;
            }

            return ints;
        }

    } // LC_A_FindNUniqueIntegersSumUpToZero class

} // CSharpPracticeExercises namespace
