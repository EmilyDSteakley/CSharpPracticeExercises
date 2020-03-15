using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_A_LuckyNumbersInAMatrix
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 1380. Lucky Numbers in a Matrix

        // Given a m * n matrix of distinct numbers, return all lucky numbers in the matrix in any order.
        // A lucky number is an element of the matrix such that it is the minimum element in its row and maximum in its column.

        // Example 1:
        // Input: matrix = [[3, 7, 8],[9,11,13],[15,16,17]]
        // Output: [15]
        // Explanation: 15 is the only lucky number since it is the minimum in its row and the maximum in its column

        // Example 2:
        // Input: matrix = [[1,10,4,2],[9,3,8,7],[15,16,17,12]]
        // Output: [12]
        // Explanation: 12 is the only lucky number since it is the minimum in its row and the maximum in its column.

        // Example 3:
        // Input: matrix = [[7, 8], [1,2]]
        // Output: [7]

        // Constraints:
        //   - m == mat.length
        //   - n == mat[i].length
        //   - 1 <= n, m <= 50
        //   - 1 <= matrix[i][j] <= 10 ^ 5.
        //   - All elements in the matrix are distinct.

        //var matrix1 = new int[3][];
        //matrix1[0] = new int[] { 3, 7, 8 };
        //matrix1[1] = new int[] { 9, 11, 13 };
        //matrix1[2] = new int[] { 15, 16, 17 };
        ////Console.WriteLine(string.Join(", ", LuckyNumbers(matrix1)));

        //var matrix2 = new int[3][];
        //matrix2[0] = new int[] { 1, 10, 4, 2 };
        //matrix2[1] = new int[] { 9, 3, 8, 7 };
        //matrix2[2] = new int[] { 15, 16, 17, 12 };
        //Console.WriteLine(string.Join(", ", LuckyNumbers(matrix2)));



        // ---------------------------------------- My Solution ----------------------------------------
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            int min;
            int max;
            var minList = new List<int>();
            var maxList = new List<int>();
            var output = new List<int>();

            for (int i = 0; i < matrix.Length; i++)
            {
                min = matrix[i][0];
                for (int j = 1; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] < min)
                        min = matrix[i][j];
                }
                minList.Add(min);
            }

            for (int k = 0; k < matrix[0].Length; k++)
            {
                max = matrix[0][k];
                for (int l = 0; l < matrix.Length; l++)
                {
                    if (matrix[l][k] > max)
                        max = matrix[l][k];
                }
                maxList.Add(max);
            }

            foreach (int num in minList)
                if (maxList.Contains(num))
                    output.Add(num);

            return output;
        }
        // 268 ms <-- Beats XX.XX%
        // Solved March 14, 2020



        // ---------------------------------------- XXX ms Solution on LeetCode ----------------------------------------



    } // LC_A_LuckyNumbersInAMatrix class

} // CSharpPracticeExercises namespace
