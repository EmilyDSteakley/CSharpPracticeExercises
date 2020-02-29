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
            // 961. N-Repeated Element in Size 2N Array
            Console.WriteLine("961. N-Repeated Element in Size 2N Array");
            var nTimes = new LC_H_NRepeatedElementInSize2NArray();
            Console.WriteLine($"Example 1: {nTimes.RepeatedNTimes(new[] { 1, 2, 3, 3 })}");
            Console.WriteLine($"Example 2: {nTimes.RepeatedNTimes(new[] { 2, 1, 2, 5, 3, 2 })}");
            Console.WriteLine($"Example 3: {nTimes.RepeatedNTimes(new[] { 5, 1, 5, 2, 5, 3, 4 })}\n\n");
            // Solved February 28, 2020


            //// Warm-up Challenges - Counting Valleys
            //Console.WriteLine("Warm-up Challenges - Counting Valleys");
            //var valleyCounter = new HR_W_CountingValleys();
            //Console.WriteLine($"Example 1: {valleyCounter.countingValleys(8, "DDUUUUDD")}");
            //Console.WriteLine($"Example 2: {valleyCounter.countingValleys(8, "UDDDUDUU")}");
            //// Solved February 27, 2020


            //// Warm-up Challenges - Repeated String
            //Console.WriteLine("Warm-up Challenges - Repeated String");
            //var aCounter = new HR_W_RepeatedString();
            //Console.WriteLine($"Example 1: {aCounter.RepeatedString("aba", 10)}");
            //Console.WriteLine($"Example 2: {aCounter.RepeatedString("a", 1000000000000)}\n\n");
            //// Solved February 26, 2020


            //// 509. Fibonacci Number
            //Console.WriteLine("509. Fibonacci Number");
            //var fibonacci = new LC_A_FibonacciNumber();
            //Console.WriteLine($"Example 1: {fibonacci.Fib1(2)}");
            //Console.WriteLine($"Example 2: {fibonacci.Fib1(3)}");
            //Console.WriteLine($"Example 3: {fibonacci.Fib1(4)}");
            //Console.WriteLine($"Example 4: {fibonacci.Fib1(5)}\n\n");
            //// Solved February 25, 2020


            //// 1204. Find N Unique Integers Sum up to Zero
            //Console.WriteLine("1204. Find N Unique Integers Sum up to Zero");
            //var zeroSum = new LC_A_FindNUniqueIntegersSumUpToZero();
            //Console.WriteLine($"Example 1: [{string.Join(", ", zeroSum.SumZero(5))}]");
            //Console.WriteLine($"Example 2: [{string.Join(", ", zeroSum.SumZero(3))}]");
            //Console.WriteLine($"Example 3: [{string.Join(", ", zeroSum.SumZero(1))}]\n\n");
            //// Solved February 22, 2020


            //// Warm-up Challenges - Sock Merchant
            //Console.WriteLine("Warm-up Challenges - Sock Merchant");
            //var sockPairs = new HR_W_SockMerchant();
            //Console.WriteLine($"Example 1: {sockPairs.SockMerchant(7, new[] { 1, 2, 1, 2, 1, 3, 2 })}");
            //Console.WriteLine($"Example 2: {sockPairs.SockMerchant(9, new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 })}\n\n");
            //// Solved February 20, 2020


            //// 1323. Maximum 69 Number
            //Console.WriteLine("1323. Maximum 69 Number");
            //var maxNumChecker = new LC_M_Maximum69Number();
            //Console.WriteLine($"Example 1: {maxNumChecker.Maximum69Number(9669)}");
            //Console.WriteLine($"Example 2: {maxNumChecker.Maximum69Number(9996)}");
            //Console.WriteLine($"Example 3: {maxNumChecker.Maximum69Number(9999)}\n\n");
            //// Solved February 19, 2020


            //// 1. Two Sum
            //Console.WriteLine("1. Two Sum");
            //var findSum = new LC_A_TwoSum();
            //Console.WriteLine($"Example 1: [{string.Join(", ", findSum.TwoSum(new[] { 2, 7, 11, 15 }, 9))}]\n\n");


            //// 680. Valid Palindrome II
            //Console.WriteLine("680. Valid Palindrome II");
            //var paliCheck2 = new LC_S_ValidPalindromeII();
            //Console.WriteLine($"Example 1: {paliCheck2.ValidPalindrome("aba")}");
            //Console.WriteLine($"Example 2: {paliCheck2.ValidPalindrome("abca")}\n\n");
            //// Solved February 18, 2020


            //// 557. Reverse Words in a String III
            //Console.WriteLine("557. Reverse Words in a String III");
            //var reverseWordsInString = new LC_S_ReverseWordsInAStringIII();
            //Console.WriteLine($"Example 1: {reverseWordsInString.ReverseWords("Let's take LeetCode contest")}\n\n");
            //// Solved February 11, 2020


            //// 125. Valid Palindrome
            //Console.WriteLine("125. Valid Palindrome");
            //var paliCheck = new LC_S_ValidPalindrome();
            //Console.WriteLine($"Example 1: {paliCheck.IsPalindrome("A man, a plan, a canal: Panama")}");
            //Console.WriteLine($"Example 2: {paliCheck.IsPalindrome("race a car")}\n\n");
            //// Solved February 11, 2020


            //// 9. Palindrome Number
            //Console.WriteLine("9. Palindrome Number");
            //var numberChecker = new LC_M_PalindromeNumber();
            //Console.WriteLine($"Example 1: {numberChecker.IsPalindrome(121)}");
            //Console.WriteLine($"Example 2: {numberChecker.IsPalindrome(-121)}");
            //Console.WriteLine($"Example 3: {numberChecker.IsPalindrome(10)}\n\n");
            //// Solved Feburary 11, 2020


            //// 344. Reverse String
            //Console.WriteLine("344. Reverse String");
            //var stringReverser = new LC_S_ReverseString();
            //stringReverser.ReverseString(new[] { 'h', 'e', 'l', 'l', 'o' });
            //stringReverser.ReverseString(new[] { 'H', 'a', 'n', 'n', 'a', 'h' });
            //Console.WriteLine("\n");
            //// Solved February 10, 2020


            //// 1295. Find Numbers with Even Number of Digits
            //Console.WriteLine("1295. Find Numbers with Even Number of Digits");
            //var numberFinder = new LC_M_FindNumbersWithEvenNumberOfDigits();
            //Console.WriteLine($"Example 1: {numberFinder.FindNumbers(new int[] { 12, 345, 2, 6, 7896 })}");
            //Console.WriteLine($"Example 2: {numberFinder.FindNumbers(new int[] { 555, 901, 482, 1771 })}\n\n");
            //// Solved January 31, 2020


            //// 1281. Subtract the Product and Sum of Digits of an Integer
            //Console.WriteLine("1281. Subtract the Product and Sum of Digits of an Integer");
            //var productSumCalc = new LC_M_SubtractTheProductAndSumOfDigitsOfAnInteger();
            //Console.WriteLine($"Example 1: {productSumCalc.SubtractProductAndSum(234)}");
            //Console.WriteLine($"Example 2: {productSumCalc.SubtractProductAndSum(53252)}\n\n");
            //// Solved January 31, 2020


        } // Main method

    } // Program class

} // CSharpPracticeExercises namespace
