using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_S_HTMLEntityParser
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 1410. HTML Entity Parser

        // HTML entity parser is the parser that takes HTML code as input and replace all the entities of the special characters by the characters itself.

        // The special characters and their entities for HTML are:
        //  - Quotation Mark: the entity is &quot; and symbol character is ".
        //  - Single Quote Mark: the entity is &apos; and symbol character is '.
        //  - Ampersand: the entity is &amp; and symbol character is &.
        //  - Greater Than Sign: the entity is &gt; and symbol character is >.
        //  - Less Than Sign: the entity is &lt; and symbol character is <.
        //  - Slash: the entity is &frasl; and symbol character is /.

        // Given the input text string to the HTML parser, you have to implement the entity parser.

        // Return the text after replacing the entities by the special characters.

        // Example 1:
        // Input: text = "&amp; is an HTML entity but &ambassador; is not."
        // Output: "& is an HTML entity but &ambassador; is not."
        // Explanation: The parser will replace the & amp; entity by &

        // Example 2:
        // Input: text = "and I quote: &quot;...&quot;"
        // Output: "and I quote: \"...\""

        // Example 3:
        // Input: text = "Stay home! Practice on Leetcode :)"
        // Output: "Stay home! Practice on Leetcode :)"

        // Example 4:
        // Input: text = "x &gt; y &amp;&amp; x &lt; y is always false"
        // Output: "x > y && x < y is always false"

        // Example 5:
        // Input: text = "leetcode.com&frasl;problemset&frasl;all"
        // Output: "leetcode.com/problemset/all"

        // Constraints:
        //  - 1 <= text.length <= 10 ^ 5
        //  - The string may contain any possible characters out of all the 256 ASCII characters.

        //Console.WriteLine(EntityParser("&amp; is an HTML entity but &ambassador; is not."));
        //Console.WriteLine(EntityParser("and I quote: &quot;...&quot;"));
        //Console.WriteLine(EntityParser("Stay home! Practice on Leetcode :)"));
        //Console.WriteLine(EntityParser("x &gt; y &amp;&amp; x &lt; y is always false"));
        //Console.WriteLine(EntityParser("leetcode.com&frasl;problemset&frasl;all"));



        // ---------------------------------------- My Solution ----------------------------------------
        public static string EntityParser(string text)
        {
            var special = new Dictionary<string, string>
            {
                { "quot;", "\"" },
                { "apos;", "\'" },
                { "amp;", "&" },
                { "gt;", ">" },
                { "lt;", "<" },
                { "frasl;", "/" }
            };

            var output = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != '&')
                    output.Append(text[i]);
                else
                {
                    var pos = i;
                    var html = new StringBuilder();
                    while (text[i] != ';')
                        html.Append(text[++i]);

                    if (special.ContainsKey(html.ToString()))
                        output.Append(special[html.ToString()]);
                    else
                    {
                        i = pos;
                        output.Append(text[i]);
                    }
                }
            }

            return output.ToString();
        }
        // 164 ms <-- Beats 73.21%
        // Solved April 11, 2020



        // ---------------------------------------- 104 ms Solution on LeetCode ----------------------------------------
        public string EntityParser104(string text)
        {
            int i = 0;
            List<char> str = new List<char>();
            bool paste = false;
            while (i < text.Length)
            {
                paste = false;
                if (text[i] == '&')
                {
                    if (i + 3 < text.Length && text[i + 3] == ';')
                    {
                        if ((text[i + 1] == 'g' && text[i + 2] == 't'))
                        {
                            i += 3;
                            str.Add('>');
                            paste = true;
                        }
                        else if ((text[i + 1] == 'l' && text[i + 2] == 't'))
                        {
                            i += 3;
                            str.Add('<');
                            paste = true;
                        }
                    }
                    if (i + 4 < text.Length && text[i + 4] == ';')
                    {
                        if (text[i + 1] == 'a' && text[i + 2] == 'm' && text[i + 3] == 'p')
                        {
                            i += 4;
                            str.Add('&');
                            paste = true;
                        }
                    }
                    if (i + 5 < text.Length && text[i + 5] == ';')
                    {
                        if ((text[i + 1] == 'q' && text[i + 2] == 'u' && text[i + 3] == 'o' && text[i + 4] == 't'))
                        {
                            str.Add('\"');
                            i += 5;
                            paste = true;
                        }
                        else if (text[i + 1] == 'a' && text[i + 2] == 'p' && text[i + 3] == 'o' && text[i + 4] == 's')
                        {
                            i += 5;
                            str.Add('\'');

                            paste = true;
                        }
                    }
                    if (i + 6 < text.Length && text[i + 6] == ';')
                    {
                        {
                            if (text[i + 1] == 'f' && text[i + 2] == 'r'
                                && text[i + 3] == 'a' && text[i + 4] == 's'
                                && text[i + 5] == 'l')
                            {
                                i += 6;
                                str.Add('/');
                                paste = true;
                            }
                        }
                    }
                }
                if (!paste && i < text.Length) str.Add(text[i]);
                i++;
            }
            return new string(str.ToArray());
        }
    }
}
