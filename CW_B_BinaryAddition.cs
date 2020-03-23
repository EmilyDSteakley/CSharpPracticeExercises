using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class CW_B_BinaryAddition
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Binary Addition

        // Implement a function that adds two numbers together and returns their sum in binary. 
        // The conversion can be done before, or after the addition.

        // The binary number returned should be a string.



        // ---------------------------------------- My Solution ----------------------------------------
        public string AddBinary(int a, int b)
        {
            var sum = a + b;
            var binary = new StringBuilder();
            while (sum != 0)
            {
                binary.Insert(0, sum % 2);
                sum /= 2;
            }
            return binary.ToString();
        }
        // Solved March 23, 2020



        // ---------------------------------------- Best Practices Solution on Codewars ----------------------------------------
        public static string AddBinaryBest(int a, int b) =>
            Convert.ToString(a + b, 2);

    } // CW_B_BinaryAddition class

} // CSharpPracticeExercises namespace
