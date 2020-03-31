using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class Interview_ReverseWordsInString
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Write a function to reverse words in a string
        // Example:
        // Input: I love to code
        // Output: code to love I



        // ---------------------------------------- My Solution ----------------------------------------

        public void ReverseWords(string s)
        {
            string[] words = s.Split();
            string[] output = new string[words.Length];

            int position = words.Length - 1;
            foreach (string word in words)
            {
                output[position] = word;
                position--;
            }
            Console.WriteLine(string.Join(" ", output));
        }

        // Don't use Split() method
        public void ReverseWordsNoSplit(string s)
        {
            List<string> words = new List<string>();
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                    temp.Append(s[i]);
                else
                {
                    words.Add(temp.ToString());
                    temp.Clear();
                }

                if (i == s.Length - 1)
                    words.Add(temp.ToString());
            }

            string[] output = new string[words.Count];

            int position = words.Count - 1;
            foreach (string word in words)
            {
                output[position] = word;
                position--;
            }
            Console.WriteLine(string.Join(" ", output));
        }
    
    } // Interview_ReverseWordsInString class

} // CSharpPracticeExercises namespace 
