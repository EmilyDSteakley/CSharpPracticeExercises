using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class CW_M_IsMyFriendCheating
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Is my friend cheating?

        //  - A friend of mine takes a sequence of numbers from 1 to n(where n > 0).
        //  - Within that sequence, he chooses two numbers, a and b.
        //  - He says that the product of a and b should be equal to the sum of all numbers in the sequence, excluding a and b.
        //  - Given a number n, could you tell me the numbers he excluded from the sequence?
        
        // The function takes the parameter: n (n is always strictly greater than 0) and returns an array or a string (depending on the language) of the form:
        // [(a, b), ...] or [[a, b], ...] or {{a, b}, ...} or or [{a, b}, ...]
        // with all (a, b) which are the possible removed numbers in the sequence 1 to n.
        // [(a, b), ...] or [[a, b], ...] or {{a, b}, ...} or ...will be sorted in increasing order of the "a".

        // It happens that there are several possible (a, b). 
        // The function returns an empty array (or an empty string) if no possible numbers are found which will prove that my friend has not told the truth! 
        // (Go: in this case return nil).

        // (See examples of returns for each language in "RUN SAMPLE TESTS")

        // Examples:

        // removNb(26) should return [(15, 21), (21, 15)]

        // or

        // removNb(26) should return { { 15, 21}, { 21, 15} }

        // or

        // removeNb(26) should return [[15, 21], [21, 15]]

        // or

        // removNb(26) should return [ {15, 21}, {21, 15} ]

        // or

        // removNb(26) should return "15 21, 21 15"

        // or

        // in C-0=
        // removNb(26) should return  ** an array of pairs {{15, 21}{21, 15}}**
        // tested by way of strings.



        // ---------------------------------------- My Solution ----------------------------------------
        public List<long[]> RemoveNb(long n)
        {
            List<long[]> output = new List<long[]>();

            long totalSum = 0;
            for (int i = 1; i <= n; i++)
                totalSum += i;

            for (int i = 1; i <= n; i++)
            {
                long possible = ((totalSum - i) / i);
                if (i < possible)
                    possible -= 1;
                if (totalSum - (i + possible) == i * possible)
                    output.Add(new long[] { i, possible });
            }

            return output;
        }
        // Solved April 7, 2020



        // ---------------------------------------- Best Practices Solution on Codewars ----------------------------------------
        public static List<long[]> RemovNbBest(long n)
        {
            List<long[]> result = new List<long[]>();
            long sumOfSeq = (n % 2 == 0) ? ((n + 1) * (n / 2)) : (n * ((n + 1) / 2));
            long b;
            for (long a = n / 2; a <= n; a++)
            {
                b = (sumOfSeq - a) / (a + 1);
                if ((b * a + b + a) == sumOfSeq)
                {
                    result.Add(new long[] { a, b });
                }
            }
            return result;
        }

    } // CW_M_IsMyFriendCheating class

} // CSharpPracticeExercises namespace
