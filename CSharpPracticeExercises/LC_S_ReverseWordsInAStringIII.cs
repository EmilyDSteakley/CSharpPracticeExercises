using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_S_ReverseWordsInAStringIII
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 557. Reverse Words in a String III
        // Given a string, you need to reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

        // Example 1:
        // Input: "Let's take LeetCode contest"
        // Output: "s'teL ekat edoCteeL tsetnoc"

        // Note: In the string, each word is separated by single space and there will not be any extra space in the string.

            

        // ---------------------------------------- My Solution ----------------------------------------
        public string ReverseWords(string s)
        {
            string[] words = s.Split(' ');
            var revWords = new string[words.Length];

            string reversedString = "";
            int n = 0;

            foreach (string word in words)
            {
                char[] chars = word.ToCharArray();
                var a = word.Length - 1;

                for (int i = 0; i <= a; i++)
                {
                    char temp = chars[i];
                    chars[i] = chars[a];
                    chars[a] = temp;
                    a--;
                }

                string newWord = new string(chars);
                revWords[n] = newWord;
                n++;
            }
            reversedString = string.Join(" ", revWords);
            return reversedString;
        }
        // 100 ms <-- Beats 63.61%
        // Solved February 11, 2020



        // ---------------------------------------- 96 ms Solution on LeetCode ----------------------------------------
        public string ReverseWords96(string s)
        {

            if (s == null || s.Length == 0)
                return s;

            var segs = s.Split(' ');
            StringBuilder sb = new StringBuilder();

            foreach (var seg in segs)
            {
                sb.Append(seg.Reverse().ToArray());
                sb.Append(' ');
            }

            var res = sb.ToString();
            res = res.TrimEnd(' ');

            return res;
        }



        // ---------------------------------------- 80 ms Solution on LeetCode ----------------------------------------
        public string ReverseWords80(string s)
        {
            int left = 0, right = 0;
            var arr = s.ToCharArray();
            while (right < s.Length)
            {
                if (arr[right] == ' ')
                {
                    Reverse(arr, left, right - 1);
                    left = right + 1;
                }
                right++;
            }
            Reverse(arr, left, right - 1);
            return new String(arr);
        }
        private void Reverse(char[] arr, int left, int right)
        {
            while (left < right)
            {
                Swap(arr, left, right);
                left++;
                right--;
            }
        }
        private void Swap(char[] arr, int left, int right)
        {
            var temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }
    }
}
