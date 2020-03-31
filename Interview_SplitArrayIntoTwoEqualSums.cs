using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class Interview_SplitArrayIntoTwoEqualSums
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Given an integer array, split the array into two parts such that the sum of the elements in each part is the same
        // Return the index of the split
        // Return -1 if it is not possibl
        // You cannot reorder the integers in the array

        // Example 1:
        // Input: {2, 4, 4, 5, 5}
        // Output: 3
        // Explanation: 2 + 4 + 4 = 10
        //              5 + 5 = 10

        // Example 2:
        // Input: {1, 1, 2, 2}
        // Ouput: -1



        // ---------------------------------------- My Solution ----------------------------------------
        
        // This only works when half is positive...
        public int SplitArray(int[] arr)
        {
            var total = 0;
            foreach (int num in arr)
                total += num;
            
            if (total % 2 != 0)
                return -1;
            else
            {
                var half = total / 2;
                var first = 0;
                var position = 0;
                while (first != half && first < half)
                {
                    first += arr[position];
                    position++;
                }
                if (first == half)
                    return position;
                else 
                    return -1;
            }
        }

        // Complete solution
        public int SplitArrayComplete(int[] arr)
        {
            var total = 0;
            foreach (int num in arr)
                total += num;
           
            var half = total / 2;
            var position = 0;
            var leftTotal = 0;

            if (half > 0)
            {
                while (leftTotal < half)
                {
                    leftTotal += arr[position++];
                }
                if (leftTotal == half)
                    return position;
            }
            else
            {
                while (leftTotal > half)
                {
                    leftTotal += arr[position++];
                }
                if (leftTotal == half)
                    return position;
            }
            return -1;
        }

    } // Interview_SplitArrayIntoTwoEqualSums class

} // CSharpPracticeExercises namespace
