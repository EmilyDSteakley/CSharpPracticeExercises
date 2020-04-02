using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class CW_M_AddingBigNumbers
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Adding Big Numbers

        // We need to sum big numbers and we require your help.

        // Write a function that returns the sum of two numbers.
        // The input numbers are strings and the function must return a string.

        // Example
        // add("123", "321"); -> "444"
        // add("11", "99");   -> "110"
        
        // Notes
        //  - The input numbers are big.
        //  - The input is a string of only digits
        //  - The numbers are positives



        // ---------------------------------------- My Solution ----------------------------------------
        public string Add(string a, string b)
        {
            var output = new Stack<double>();
            var total = new StringBuilder();

            var aPos = a.Length;
            var bPos = b.Length;
            int longer = Math.Max(aPos, bPos);
            var carry = 0;
            for (int i = longer - 1; i >= 0; i--)
            {
                char aDigit = aPos > 0 ? a[--aPos] : '0';
                char bDigit = bPos > 0 ? b[--bPos] : '0';
                output.Push(Add(aDigit, bDigit, ref carry));
            }

            if (carry != 0)
                output.Push(carry);

            while (output.Count != 0)
                total.Append(output.Pop());

            return total.ToString();
        }

        public double Add(char a, char b, ref int carry)
        {
            var sum = char.GetNumericValue(a) + char.GetNumericValue(b) + carry;
            carry = (int) sum / 10;
            return sum % 10;
        }
        // Solved April 1, 2020



        // ---------------------------------------- Best Practices Solution on Codewars ----------------------------------------
         public string AddBest(string a, string b)
         {   
            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString(); // Fix this!
         }

        public string AddBest2(string a, string b)
        {
            var reverseResult = new StringBuilder();
            int aLength = a.Length, bLength = b.Length, length = aLength > bLength ? aLength : bLength, carry = 0;
            a = a.PadLeft(length, '0');
            b = b.PadLeft(length, '0');

            for (var index = length - 1; index >= 0; index--)
            {
                var sum = carry + a[index] - 48 + b[index] - 48;
                reverseResult.Append(sum % 10);
                carry = sum / 10;
            }

            if (carry > 0)
            {
                reverseResult.Append(1);
            }

            var result = reverseResult.ToString().ToCharArray();

            Array.Reverse(result);

            return String.Join(String.Empty, result);
        }

    } // CW_M_AddingBigNumbers class

} // CSharpPracticeExercises namespace
