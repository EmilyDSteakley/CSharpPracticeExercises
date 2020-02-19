using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMath
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1295. Find Numbers with Even Number of Digits
            Console.WriteLine("1295. Find Numbers with Even Number of Digits");
            var _1295_example1 = new int[] { 12, 345, 2, 6, 7896 };
            var _1295_example2 = new int[] { 555, 901, 482, 1771 };
            var numberFinder = new FindNumbersWithEvenNumberOfDigits();
            Console.WriteLine($"Example 1: {numberFinder.FindNumbers(_1295_example1)}");
            Console.WriteLine($"Example 2: {numberFinder.FindNumbers(_1295_example2)}\n\n");
            // Solved January 31, 2020


            // 1281. Subtract the Product and Sum of Digits of an Integer
            Console.WriteLine("1281. Subtract the Product and Sum of Digits of an Integer");
            var productSumCalc = new SubtractTheProductAndSumOfDigitsOfAnInteger();
            Console.WriteLine($"Example 1: {productSumCalc.SubtractProductAndSum(234)}");
            Console.WriteLine($"Example 2: {productSumCalc.SubtractProductAndSum(35252)}\n\n");
            // Solved January 31, 2020


            // 9. Palindrome Number
            Console.WriteLine("9. Palindrome Number");
            var _9_example1 = 121;
            var _9_example2 = -121;
            var _9_example3 = 10;
            var numberChecker = new PalindromeNumber();
            Console.WriteLine($"Example 1: {numberChecker.IsPalindrome(_9_example1)}");
            Console.WriteLine($"Example 2: {numberChecker.IsPalindrome(_9_example2)}");
            Console.WriteLine($"Example 3: {numberChecker.IsPalindrome(_9_example3)}");
            // Solved Feburary 11, 2020


            // 1323. Maximum 69 Number
            Console.WriteLine("1323. Maximum 69 Number");
            var _1323_example1 = 9669;
            var _1323_example2 = 9996;
            var _1323_example3 = 9999;
            var maxNumChecker = new Maximum69Number();
            Console.WriteLine($"Example 1: {maxNumChecker.Max69Number(_1323_example1)}");
            Console.WriteLine($"Example 2: {maxNumChecker.Max69Number(_1323_example2)}");
            Console.WriteLine($"Example 3: {maxNumChecker.Max69Number(_1323_example3)}");








        } // Main method

    } // Program class

} // LeetCodeMath namespace
