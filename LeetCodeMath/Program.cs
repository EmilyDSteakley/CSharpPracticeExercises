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
            Console.WriteLine($"Example 1: {FindNumbersWithEvenNumberOfDigits.FindNumbers(_1295_example1)}");
            Console.WriteLine($"Example 2: {FindNumbersWithEvenNumberOfDigits.FindNumbers(_1295_example2)}\n\n");
            // Solved January 31, 2020


            // 1281. Subtract the Product and Sum of Digits of an Integer
            Console.WriteLine("1281. Subtract the Product and Sum of Digits of an Integer");
            var productSumCalc = new SubtractTheProductAndSumOfDigitsOfAnInteger();
            Console.WriteLine($"Example 1: {productSumCalc.SubtractProductAndSum24(234)}");
            Console.WriteLine($"Example 2: {productSumCalc.SubtractProductAndSum24(35252)}");
            // Solved January 31, 2020
        }
    }
}
