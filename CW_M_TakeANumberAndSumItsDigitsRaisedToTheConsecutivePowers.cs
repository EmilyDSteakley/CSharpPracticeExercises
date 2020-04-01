using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class CW_M_TakeANumberAndSumItsDigitsRaisedToTheConsecutivePowers
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Take a Number And Sum Its Digits Raised To The Consecutive Powers And ....¡Eureka!!

        // The number 89 is the first integer with more than one digit that fulfills the property partially introduced in the title of this kata. 
        // What's the use of saying "Eureka"? 
        // Because this sum gives the same number.

        // In effect: 89 = 8^1 + 9^2

        // The next number in having this property is 135.

        // See this property again: 135 = 1^1 + 3^2 + 5^3

        // We need a function to collect these numbers, that may receive two integers a, b that defines the range[a, b] (inclusive) and 
        // outputs a list of the sorted numbers in the range that fulfills the property described above.

        // Let's see some cases:

        // sum_dig_pow(1, 10) == [1, 2, 3, 4, 5, 6, 7, 8, 9]
        // sum_dig_pow(1, 100) == [1, 2, 3, 4, 5, 6, 7, 8, 9, 89]

        // If there are no numbers of this kind in the range[a, b] the function should output an empty list.
        // sum_dig_pow(90, 100) == []

        // Enjoy it!!



        // ---------------------------------------- My Solution ----------------------------------------
        public long[] SumDigPow(long a, long b)
        {
            var output = new List<long>();
            for (long i = a; i <= b; i++)
            {
                var num = i;
                var digits = new Stack<byte>();
                while (num > 0)
                {
                    digits.Push((byte)(num % 10));
                    num /= 10;
                }

                long sum = 0;
                var place = 1;
                while (digits.Count != 0)
                {
                    sum += (long)Math.Pow(digits.Pop(), place++);
                }

                if (sum == i)
                    output.Add(sum);
            }

            return output.ToArray<long>();
        }
        // Solved March 31, 2020



        // ---------------------------------------- Best Practices Solution on Codewars ----------------------------------------
        public static long[] SumDigPowBest(long a, long b)
        {
            List<long> values = new List<long>();
            for (long x = a; x <= b; x++)
            {
                if (x.ToString().Select((c, i) => Math.Pow(Char.GetNumericValue(c), i + 1)).Sum() == x)
                    values.Add(x);
            }
            return values.ToArray();
        }

    } // CW_M_TakeANumberAndSumItsDigitsRaisedToTheConsecutivePowers class

} // CSharpPracticeExercises namespace
