using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class CW_A_MovingZerosToTheEnd
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Moving Zeroes To The End

        // Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
        // Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}

        
        
        // ---------------------------------------- My Solution ----------------------------------------
        public int[] MoveZeroes(int[] arr)
        {
            var good = 0;
            var check = 0;
            while (check < arr.Length)
            {
                if (arr[good] != 0)
                {
                    good++;
                    check++;
                }
                else
                {
                    while (arr[check] == 0)
                    {
                        if (check < arr.Length - 1)
                            check++;
                        else
                            break;
                    }
                    (arr[good], arr[check]) = (arr[check], arr[good]);
                    good++;
                    check++;
                }
            }
            return arr;
        }
        // Solved April 2, 2020



        // ---------------------------------------- Best Practices Solution on Codewars ----------------------------------------
        public static int[] MoveZeroesBest(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ToArray();
        }

        public static int[] MoveZeroesBest2(int[] arr)
        {
            // This solution makes use of C#'s behaviour with unassigned ints in arrays: They are 0 by default.
            // So we basically only have to create a new array with the same size, and write non-zero values
            // in their usual order. Simple.
            int[] zeroesAtEnd = new int[arr.Length];
            int currIndex = -1;
            foreach (int num in arr)
            {
                if (num != 0)
                {
                    currIndex++;
                    zeroesAtEnd[currIndex] = num;
                }
            }
            return zeroesAtEnd;
        }

    } // CW_A_MovingZerosToTheEnd class

} // CSharpPracticeExercises namespace
