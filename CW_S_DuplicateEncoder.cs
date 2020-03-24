using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class CW_S_DuplicateEncoder
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Duplicate Encoder

        // The goal of this exercise is to convert a string to a new string where each character in the new string is 
        // "(" if that character appears only once in the original string, or 
        // ")" if that character appears more than once in the original string. 
        // Ignore capitalization when determining if a character is a duplicate.

        // Examples
        // "din"      =>  "((("
        // "recede"   =>  "()()()"
        // "Success"  =>  ")())())"
        // "(( @"     =>  "))((" 
        

        
        // ---------------------------------------- My Solution ----------------------------------------
        public string DuplicateEncoder(string word)
        {
            string lowerWord = word.ToLower();
            var output = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                if (lowerWord.IndexOf(lowerWord[i]) == lowerWord.LastIndexOf(lowerWord[i]))
                    output.Append("(");
                else
                    output.Append(")");
            }
            return output.ToString();
        }
        // Solved March 23, 2020



        // ---------------------------------------- Best Practices Solution on Codewars ----------------------------------------
        public string DuplicateEncoderBest(string word)
        {
            return new string(word.ToLower().Select(ch => word.ToLower().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray());
        }

    } // CW_S_DuplicateEncoder class

} // CSharpPracticeExercises namespace
