using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_A_PascalsTriangle
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 118. Pascal's Triangle

        // Given a non-negative integer numRows, generate the first numRows of Pascal's triangle.

        // In Pascal's triangle, each number is the sum of the two numbers directly above it.

        // Example:

        // Input: 5
        // Output:
        // [
        //      [1],
        //     [1,1],
        //    [1,2,1],
        //   [1,3,3,1],
        //  [1,4,6,4,1]
        // ]



        // ---------------------------------------- My Solution ----------------------------------------
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> output = new List<IList<int>>();

            if (numRows <= 0)
                return output;

            output.Add(new List<int> { 1 });
            for (int i = 1; i < numRows; i++)
            {
                var temp = new List<int> { 1 };
                for (int j = 1; j <= i - 1; j++)
                {
                    temp.Add(output[i - 1][j - 1] + output[i - 1][j]);
                }
                temp.Add(1);
                output.Add(temp);
            }
            return output;
        }
        // 204 ms <-- Beats 87.79%
        // Solved March 11, 2020



        public int[][] Generate2(int numRows)
        {
            var output = new int[numRows][];
            for (int i = 0; i < numRows; i++)
            {
                output[i] = new int[i + 1];
                output[i][0] = 1;
                output[i][i] = 1;
                if (i > 1)
                {
                    for (int j = 1; j < i; j++)
                    {
                        output[i][j] = output[i - 1][j - 1] + output[i - 1][j];
                    }
                }
            }
            return output;
        }
        // 208 ms <-- Beats 68.87%
        // Solved March 9, 2020



        // ---------------------------------------- 188 ms Solution on LeetCode ----------------------------------------
        public IList<IList<int>> Generate188(int numRows)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if (numRows == 0) return res;
            res.Add(new List<int>() { 1 });
            for (int i = 2; i <= numRows; i++)
            {
                IList<int> temp = new List<int>();
                var prev = res[res.Count - 1];
                var len = prev.Count;
                temp.Add(1);
                for (int j = 0; j < len - 1; j++)
                {
                    temp.Add(prev[j] + prev[j + 1]);
                }
                temp.Add(1);
                res.Add(temp);
            }
            return res;
        }

    } // LC_A_PascalsTriangle class

} // CSharpPracticeExercises namespace
