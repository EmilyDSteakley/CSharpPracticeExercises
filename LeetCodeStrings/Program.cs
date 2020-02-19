using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // 344. Reverse String
            Console.WriteLine("344. Reverse String");
            var _344_example1 = new[] { 'h', 'e', 'l', 'l', 'o' };
            var _344_example2 = new[] { 'H', 'a', 'n', 'n', 'a', 'h' };
            var stringReverser = new ReverseString();
            stringReverser.ReverseStrings(_344_example1);
            stringReverser.ReverseStrings(_344_example2);
            // Solved February 10, 2020

            Console.WriteLine();

            // 557. Reverse Words in a String III
            Console.WriteLine("557. Reverse Words in a String III");
            var _557_example1 = "Let's take LeetCode contest";
            var reverseWordsInString = new ReverseWordsInAStringIII();
            Console.WriteLine($"Example 1: {reverseWordsInString.ReverseWords(_557_example1)}\n");


            // 125. Valid Palindrome
            Console.WriteLine("125. Valid Palindrome");
            var _125_example1 = "A man, a plan, a canal: Panama";
            var _125_example2 = "race a car";
            var paliCheck = new ValidPalindrome();
            Console.WriteLine($"Example 1: {paliCheck.IsPalindrome(_125_example1)}");
            Console.WriteLine($"Example 2: {paliCheck.IsPalindrome(_125_example2)}");




        } // Main method

    } // Program class

} // LeetCodeStrings namespace
