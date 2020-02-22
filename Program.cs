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

            var zeroSum = new LC_A_FindNUniqueIntegersSumUpToZero();
            //Console.WriteLine($"[{string.Join(", ", zeroSum.SumZero(5))}]");
            //Console.WriteLine($"[{string.Join(", ", zeroSum.SumZero(4))}]");
            //Console.WriteLine($"[{string.Join(", ", zeroSum.SumZero(3))}]");
            //Console.WriteLine($"[{string.Join(", ", zeroSum.SumZero(1))}]");

            Console.WriteLine($"[{string.Join(", ", zeroSum.SumZero188(5))}]");




        } // Main method

    } // Program class

} // CSharpPracticeExercises namespace
