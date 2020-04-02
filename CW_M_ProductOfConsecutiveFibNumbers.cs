using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class CW_M_ProductOfConsecutiveFibNumbers
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Product of consecutive Fib numbers

        // The Fibonacci numbers are the numbers in the following integer sequence (Fn):
        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ...
        // such as
        // F(n) = F(n-1) + F(n-2) with F(0) = 0 and F(1) = 1.

        // Given a number, say prod(for product), we search two Fibonacci numbers F(n) and F(n+1) verifying
        // F(n) * F(n+1) = prod.

        // Your function productFib takes an integer(prod) and returns an array:
        // [F(n), F(n + 1), true] or {F(n), F(n+1), 1} or (F(n), F(n+1), True)
        // depending on the language if F(n) * F(n+1) = prod.

        // If you don't find two consecutive F(m) verifying F(m) * F(m+1) = prod you will return
        // [F(m), F(m + 1), false] or {F(n), F(n+1), 0} or (F(n), F(n+1), False)
        // F(m) being the smallest one such as F(m) * F(m+1) > prod.

        // Some Examples of Return: (depend on the language)

        // productFib(714) # should return (21, 34, true), 
        //                 # since F(8) = 21, F(9) = 34 and 714 = 21 * 34

        // productFib(800) # should return (34, 55, false), 
        //                 # since F(8) = 21, F(9) = 34, F(10) = 55 and 21 * 34 < 800 < 34 * 55
        // -----
        // productFib(714) # should return [21, 34, true], 
        // productFib(800) # should return [34, 55, false], 
        // -----
        // productFib(714) # should return {21, 34, 1}, 
        // productFib(800) # should return {34, 55, 0},        
        // -----
        // productFib(714) # should return {21, 34, true}, 
        // productFib(800) # should return {34, 55, false}, 

        // Note:
        // You can see examples for your language in "Sample Tests".



        // ---------------------------------------- My Solution ----------------------------------------
        public ulong[] ProductFib(ulong prod)
        {
            ulong result = 0;
            ulong first = 0;
            ulong second = 0;
            for (ulong i = 0; result < prod; i++)
            {
                first = Fib(i);
                second = Fib(i + 1);
                result = first * second;
            }
            if (result == prod)
                return new ulong[] { first, second, 1 };
            else
                return new ulong[] { first, second, 0 };
        }

        public ulong Fib(ulong N)
        {
            ulong before1 = 0;
            ulong before2 = 1;
            ulong total = 0;
            for (ulong i = 1; i <= N; i++)
            {
                total = before1 + before2;
                (before2, before1) = (before1, total);
            }
            return total;
        }
        // Solved April 2, 2020



        // ---------------------------------------- Best Practices Solution on Codewars ----------------------------------------
        public static ulong[] productFib(ulong prod)
        {
            ulong[] result = { 0, 1, 0 };
            ulong next = 1;
            while (result[0] * result[1] < prod)
            {
                next = result[0] + result[1];
                result[0] = result[1];
                result[1] = next;
            }
            if (result[0] * result[1] == prod)
                result[2] = 1;
            return result;
        }

    } // CW_M_ProductOfConsecutiveFibNumbers class

} // CSharpPracticeExercises namespace
