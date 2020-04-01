using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class CW_AL_GreedIsGood
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Greed is a dice game played with five six-sided dice. 
        // Your mission, should you choose to accept it, is to score a throw according to these rules. 
        // You will always be given an array with five six-sided dice values.

        // Three 1's => 1000 points
        // Three 6's =>  600 points
        // Three 5's =>  500 points
        // Three 4's =>  400 points
        // Three 3's =>  300 points
        // Three 2's =>  200 points
        // One   1   =>  100 points
        // One   5   =>   50 point
        
        // A single die can only be counted once in each roll.
        // For example, a "5" can only count as part of a triplet (contributing to the 500 points) or as a single 50 points, but not both in the same roll.

        // Example scoring
        //     Throw       Score
        //     ---------   ------------------
        //     5 1 3 4 1   50 + 2 * 100 = 250
        //     1 1 1 3 1   1000 + 100 = 1100
        //     2 4 4 5 4   400 + 50 = 450
               
        // In some languages, it is possible to mutate the input to the function.
        // This is something that you should never do. If you mutate the input, you will not be able to pass all the tests.



        // ---------------------------------------- My Solution ----------------------------------------
        public int Score(int[] dice)
        {
            var score = 0;
            var roll = new Dictionary<int, int>();
            foreach (var single in dice)
            {
                if (!roll.ContainsKey(single))
                    roll.Add(single, 1);
                else
                    roll[single]++;
            }

            foreach (KeyValuePair<int, int> set in roll)
            {
                if (set.Value >= 3)
                    if (set.Key == 1)
                        score += 1000;
                    else
                        score += (set.Key * 100);

                if (set.Key == 1)
                    if (score == 1000)
                        score += ((set.Value - 3) * 100);
                    else
                        score += (set.Value * 100);
                else if (set.Key == 5)
                    if (score == 500)
                        score += ((set.Value - 3) * 50);
                    else
                        score += (set.Value * 50);
            }

            return score;
        }
        // Solved April 1, 2020



        // ---------------------------------------- Best Practices Solution on Codewars ----------------------------------------
        public static int ScoreBest(int[] dice)
        {
            int[] tripleValue = { 0, 1000, 200, 300, 400, 500, 600 };
            int[] singleValue = { 0, 100, 0, 0, 0, 50, 0 };

            int value = 0;
            for (int dieSide = 1; dieSide <= 6; dieSide++)
            {
                int countRolls = dice.Where(outcome => outcome == dieSide).Count();
                value += tripleValue[dieSide] * (countRolls / 3) + singleValue[dieSide] * (countRolls % 3);
            }
            return value;
        }


    } // CW_AL_GreedIsGood class

} // CSharpPracticeExercises namespace
