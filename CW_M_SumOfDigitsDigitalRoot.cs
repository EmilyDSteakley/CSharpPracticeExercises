using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class CW_M_SumOfDigitsDigitalRoot
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Sum of Digits / Digital Root

        // In this kata, you must create a digital root function.

        // A digital root is the recursive sum of all the digits in a number.
        // Given n, take the sum of the digits of n. 
        // If that value has more than one digit, continue reducing in this way until a single-digit number is produced.
        // This is only applicable to the natural numbers.

        // Here's how it works:
        // digital_root(16)
        // => 1 + 6
        // => 7

        // digital_root(942)
        // => 9 + 4 + 2
        // => 15 ...
        // => 1 + 5
        // => 6

        // digital_root(132189)
        // => 1 + 3 + 2 + 1 + 8 + 9
        // => 24 ...
        // => 2 + 4
        // => 6

        // digital_root(493193)
        // => 4 + 9 + 3 + 1 + 9 + 3
        // => 29 ...
        // => 2 + 9
        // => 11 ...
        // => 1 + 1
        // => 2



        // ---------------------------------------- My Solution ----------------------------------------
        public int DigitalRoot(long n)
        {
            while (n > 9)
            {
                int sum = 0;
                while (n > 0)
                {
                    sum += (int)(n % 10);
                    n /= 10;
                }
                n = sum;
            }
            return (int)n;
        }
        // Solved March 23, 2020



        // ---------------------------------------- Best Practices Solution on Codewars ----------------------------------------
        public int DigitalRootBest(long n)
        {
            return (int)(1 + (n - 1) % 9);
        }

    } // CW_M_SumOfDigitsDigitalRoot class

} // CSharpPracticeExercises namespace
