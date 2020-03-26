using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class CW_M_JoshephusSurvivor
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Josephus Survivor

        // In this kata you have to correctly return who is the "survivor", ie: the last element of a Josephus permutation.

        // Basically you have to assume that n people are put into a circle and that they are eliminated in steps of k elements, like this:

        // josephus_survivor(7,3) => means 7 people in a circle; one every 3 is eliminated until one remains
        //  [1,2,3,4,5,6,7] - initial sequence
        //  [1,2,4,5,6,7] => 3 is counted out
        //  [1,2,4,5,7] => 6 is counted out
        //  [1,4,5,7] => 2 is counted out
        //  [1,4,5] => 7 is counted out
        //  [1,4] => 5 is counted out
        //  [4] => 1 counted out, 4 is the last element - the survivor!

        // The above link about the "base" kata description will give you a more thorough insight about the origin of this kind of permutation, 
        // but basically that's all that there is to know to solve this kata.

        // Notes and tips: using the solution to the other kata to check your function may be helpful, 
        // but as much larger numbers will be used, using an array/list to compute the number of the survivor may be too slow; 
        // you may assume that both n and k will always be >=1.



        // ---------------------------------------- My Solution ----------------------------------------
        public int JosSurvivor(int n, int k)
        {
            var items = new List<int>();
            items.AddRange(Enumerable.Range(1, n));
            PrintList(items);

            var next = 0;
            while (items.Count > 1)
            {
                next += k - 1;
                while (next >= items.Count)
                    next -= items.Count;
                Console.WriteLine(items[next]);
                items.RemoveAt(next);
                PrintList(items);
            }
            return items[0];
        }
        // Solved March 26, 2020

        public void PrintList(List<int> list)
        {
            Console.WriteLine($"[{string.Join(", ", list)}]");
        }



        // ---------------------------------------- Best Practices Solution on Codewars ----------------------------------------



    } // CW_M_JoshephusSurvivor class

} // CSharpPracticeExercises namespace
