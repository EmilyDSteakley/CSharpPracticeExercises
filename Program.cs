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
            var n1 = 7;
            var ar1 = new[] { 1, 2, 1, 2, 3, 2 };

            var n2 = 9;
            var ar2 = new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20};

            var merchant = new HR_W_SockMerchant();
            Console.WriteLine(merchant.sockMerchant(n1, ar1));
            Console.WriteLine(merchant.sockMerchant(n2, ar2));







        } // Main method

    } // Program class

} // CSharpPracticeExercises namespace
