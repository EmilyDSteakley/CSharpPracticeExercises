using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class HR_W_SockMerchant
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Warm-up Challenges - Sock Merchant

        // John works at a clothing store. He has a large pile of socks that he must pair by color for sale. 
        // Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.

        // For example, there are n = 7 socks with colors ar = [1,,2,1,2,3,2]. There is one pair of color 1 and one of color 2. T
        // here are three odd socks left, one of each color. The number of pairs is 2.

        // Function Description
        // Complete the sockMerchant function in the editor below. 
        // It must return an integer representing the number of matching pairs of socks that are available.
        
        // sockMerchant has the following parameter(s):
        //  - n: the number of socks in the pile
        //  - ar: the colors of each sock

        // Input Format
        // The first line contains an integer n, the number of socks represented in ar.
        // The second line contains n space-separated integers describing the colors ar[i] of the socks in the pile.

        // Constraints
        //  - 1 <= n <= 100
        //  - 1 <= ar[i] <= 100 where 0 <= i < n

        // Output Format
        // Return the total number of matching pairs of socks that John can sell.

        // Sample Input
        // 9
        // 10 20 20 10 10 30 50 10 20

        // Sample Output
        // 3



        // ---------------------------------------- My Solution ----------------------------------------
        public int sockMerchant(int n, int[] ar)
        {
            var colorPairs = new Dictionary<int, int>();
            int pairs = 0;

            foreach (int i in ar)
            {
                if (!colorPairs.ContainsKey(i))
                {
                    colorPairs.Add(i, 1);
                }
                else
                {
                    colorPairs[i] += 1;
                }
            }

            foreach (int j in colorPairs.Keys)
            {
                pairs += colorPairs[j] / 2;
            }

            return pairs;
        }
        // Solved February 20, 2020

    } // HR_W_SockMerchant class

} // CSharpPracticeExercises namespace

