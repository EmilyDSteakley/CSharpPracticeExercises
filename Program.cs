using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class Program
    {
        static void Main(string[] args)
        {



            //var counter = new HR_W_CountingValleys();
            //Console.WriteLine(counter.countingValleys(n1, s1));
            //Console.WriteLine(counter.countingValleys(n2, s2));

            //var zeroSum = new LC_A_FindNUniqueIntegersSumUpToZero();
            //Console.WriteLine($"[{string.Join(", ", zeroSum.SumZero(5))}]");
            //Console.WriteLine($"[{string.Join(", ", zeroSum.SumZero(3))}]");
            //Console.WriteLine($"[{string.Join(", ", zeroSum.SumZero(1))}]");





            // 9. Palindrome Number
            Console.WriteLine("9. Palindrome Number");
            var _9_example1 = 121;
            var _9_example2 = -121;
            var _9_example3 = 10;
            var numberChecker = new LC_M_PalindromeNumber();
            Console.WriteLine($"Example 1: {numberChecker.IsPalindrome(_9_example1)}");
            Console.WriteLine($"Example 2: {numberChecker.IsPalindrome(_9_example2)}");
            Console.WriteLine($"Example 3: {numberChecker.IsPalindrome(_9_example3)}\n\n");
            // Solved Feburary 11, 2020


            // 1323. Maximum 69 Number
            Console.WriteLine("1323. Maximum 69 Number");
            var _1323_example1 = 9669;
            var _1323_example2 = 9996;
            var _1323_example3 = 9999;
            var maxNumChecker = new LC_M_Maximum69Number();
            Console.WriteLine($"Example 1: {maxNumChecker.Maximum69Number(_1323_example1)}");
            Console.WriteLine($"Example 2: {maxNumChecker.Maximum69Number(_1323_example2)}");
            Console.WriteLine($"Example 3: {maxNumChecker.Maximum69Number(_1323_example3)}");
            // Solved February 19, 2020





            // 557. Reverse Words in a String III
            Console.WriteLine("557. Reverse Words in a String III");
            var _557_example1 = "Let's take LeetCode contest";
            var reverseWordsInString = new LC_S_ReverseWordsInAStringIII();
            Console.WriteLine($"Example 1: {reverseWordsInString.ReverseWords(_557_example1)}\n");
            // Solved February 11, 2020


            // 125. Valid Palindrome
            Console.WriteLine("125. Valid Palindrome");
            var _125_example1 = "A man, a plan, a canal: Panama";
            var _125_example2 = "race a car";
            var paliCheck = new LC_S_ValidPalindrome();
            Console.WriteLine($"Example 1: {paliCheck.IsPalindrome(_125_example1)}");
            Console.WriteLine($"Example 2: {paliCheck.IsPalindrome(_125_example2)}\n");
            // Solved February 11, 2020


            // 680. Valid Palindrome II
            Console.WriteLine("680. Valid Palindrome II");
            var _680_example1 = "aba";
            var _680_example2 = "abca";
            var paliCheck2 = new LC_S_ValidPalindromeII();
            Console.WriteLine($"Example 1: {paliCheck2.ValidPalindrome(_680_example1)}");
            Console.WriteLine($"Example 2: {paliCheck2.ValidPalindrome(_680_example2)}");
            // Solved February 18, 2020






            // 344. Reverse String
            Console.WriteLine("344. Reverse String");
            var _344_example1 = new[] { 'h', 'e', 'l', 'l', 'o' };
            var _344_example2 = new[] { 'H', 'a', 'n', 'n', 'a', 'h' };
            var stringReverser = new LC_S_ReverseString();
            stringReverser.ReverseString(_344_example1);
            stringReverser.ReverseString(_344_example2);
            // Solved February 10, 2020


            // 1295. Find Numbers with Even Number of Digits
            Console.WriteLine("1295. Find Numbers with Even Number of Digits");
            var _1295_example1 = new int[] { 12, 345, 2, 6, 7896 };
            var _1295_example2 = new int[] { 555, 901, 482, 1771 };
            var numberFinder = new LC_M_FindNumbersWithEvenNumberOfDigits();
            Console.WriteLine($"Example 1: {numberFinder.FindNumbers(_1295_example1)}");
            Console.WriteLine($"Example 2: {numberFinder.FindNumbers(_1295_example2)}\n\n");
            // Solved January 31, 2020


            // 1281. Subtract the Product and Sum of Digits of an Integer
            Console.WriteLine("1281. Subtract the Product and Sum of Digits of an Integer");
            var productSumCalc = new LC_M_SubtractTheProductAndSumOfDigitsOfAnInteger();
            Console.WriteLine($"Example 1: {productSumCalc.SubtractProductAndSum(234)}");
            Console.WriteLine($"Example 2: {productSumCalc.SubtractProductAndSum(35252)}\n\n");
            // Solved January 31, 2020


        } // Main method

    } // Program class

} // CSharpPracticeExercises namespace
