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
            var example1 = new[] { 'h', 'e', 'l', 'l', 'o' };
            var example2 = new[] { 'H', 'a', 'n', 'n', 'a', 'h' };
            ReverseString.ReverseStrings(example1);
            ReverseString.ReverseStrings(example2);
            // Solved February 10, 2020
        }
    }
}
