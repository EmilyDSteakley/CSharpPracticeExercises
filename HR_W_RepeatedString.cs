using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class HR_W_RepeatedString
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Warm-up Challenges - Repeated String

        // Lilah has a string, s, of lowercase English letters that she repeated infinitely many times.
        // Given an integer, n, find and print the number of letter a's in the first n letters of Lilah's infinite string.

        // For example, if the string s = "abcac" and n = 10, the substring we consider is abcacabcac, the first 10 characters of her infinite string.
        // There are 4 occurrences of a in the substring.

        // Function Description
        // Complete the repeatedString function in the editor below. 
        // It should return an integer representing the number of occurrences of a in the prefix of length n in the infinitely repeating string.

        // repeatedString has the following parameter(s) :
        //  - s: a string to repeat
        //  - n: the number of characters to consider

        // Input Format
        // The first line contains a single string, s.
        // The second line contains an integer, n.

        // Constraints
        //  - 1 <= |s| <= 100
        //  - 1 <= n <= 10^12
        //  - For 25% of the test cases, n <= 10^6

        // Output Format
        // Print a single integer denoting the number of letter a's in the first n letters of the infinite string created by repeating s infinitely many times.

        // Sample Input 0
        // aba
        // 10

        // Sample Output 0
        // 7

        // Explanation
        // The first n = 10 letters of the infinite string are abaabaabaa. Because there are 7 a's, we print 7 on a new line.

        // Sample Input 1
        // a
        // 1000000000000

        // Sample Output 1
        // 1000000000000

        // Explanation
        // Becuase all of the first n = 1000000000000 letters of the infinite string are a, we print 1000000000000 on a new line.



        // ---------------------------------------- My Solution ----------------------------------------
        public long RepeatedString(string s, long n)
        {
            long subTimes;
            long aInSub;
            int counter = 0;

            foreach (char letter in s)
            {
                if (letter == 'a')
                    counter++;
            }

            subTimes = n / s.Length;
            aInSub = subTimes * counter;
            subTimes *= s.Length;

            for (int i = 0; i < n - subTimes; i++)
            {
                if (s[i] == 'a')
                    aInSub++;
            }

            return aInSub;
        }
        // Solved February 27, 2020

    } // HR_W_RepeatedString class

}// CSharpPracticeExercises namespace
