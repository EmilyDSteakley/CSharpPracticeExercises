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
            var example1 = new int[] { 12, 345, 2, 6, 7896 };
            var example2 = new int[] { 555, 901, 482, 1771 };
            Console.WriteLine($"Example 1: {FindNumbersWithEvenNumberOfDigits.FindNumbers(example1)}");
            Console.WriteLine($"Example 2: {FindNumbersWithEvenNumberOfDigits.FindNumbers(example2)}\n\n");
            // Solved January 31, 2020


            // 1281. Subtract the Product and Sum of Digits of an Integer
            Console.WriteLine("1281. Subtract the Product and Sum of Digits of an Integer");
            Console.WriteLine($"Example 1: {SubtractTheProductAndSumOfDigitsOfAnInteger.SubtractProductAndSum(234)}");
            Console.WriteLine($"Example 2: {SubtractTheProductAndSumOfDigitsOfAnInteger.SubtractProductAndSum(35252)}");
            // Solved January 31, 2020
        }
    }
}
