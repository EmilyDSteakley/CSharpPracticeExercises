using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class CW_AL_RGBToHexConversion
    {
        // ---------------------------------------- Problem ----------------------------------------

        // RGB To Hex Conversion

        // The rgb() method is incomplete. 
        // Complete the method so that passing in RGB decimal values will result in a hexadecimal representation being returned. 
        // The valid decimal values for RGB are 0 - 255. 
        // Any (r,g,b) argument values that fall out of that range should be rounded to the closest valid value.

        // The following are examples of expected output values:
        // Rgb(255, 255, 255) # returns FFFFFF
        // Rgb(255, 255, 300) # returns FFFFFF
        // Rgb(0,0,0) # returns 000000
        // Rgb(148, 0, 211) # returns 9400D3



        // ---------------------------------------- My Solution ----------------------------------------
        public string Rgb(int r, int g, int b)
        {
            return HexConvert(r) + HexConvert(g) + HexConvert(b);
        }

        public string HexConvert(int num)
        {
            var hex = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            var output = new StringBuilder();

            if (num > 255)
                num = 255;
            else if (num <= 0)
                return "00";

            output.Append(hex[num / 16]);
            output.Append(hex[num % 16]);

            return output.ToString();
        }
        // Solved March 30, 2020



        // ---------------------------------------- Best Practices Solution on Codewars ----------------------------------------
        public string RgbBest(int r, int g, int b)
        {
            r = Math.Max(Math.Min(255, r), 0);
            g = Math.Max(Math.Min(255, g), 0);
            b = Math.Max(Math.Min(255, b), 0);
            return String.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
        }

    } // CW_AL_RGBToHexConversion class

} // CSharpPracticeExercises namespace
