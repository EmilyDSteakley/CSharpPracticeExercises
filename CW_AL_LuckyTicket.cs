using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class CW_AL_LuckyTicket
    {
        // ---------------------------------------- Problem ----------------------------------------

        // When computers were big and Internet was small, passengers used tickets on public transport service.

        // Quite often, there was a 6-digit number printed on each ticket.
        // The number started from 000 000 and went all the way up to 999 999.

        // Some passengers were lucky to get a lucky ticket that promised a good lucky day!
        // The lucky ticket had the sum of the first three digits equals to the sum of the last three digits.

        // For example, 123 006 is the lucky one (1+2+3=6=0+0+6); 123 122 is NOT lucky(1+2+3=6≠5=1+2+2).

        // Write a method that takes an integer index number and returns a 6-digit string with a lucky ticket number from a zero-based list of all lucky tickets in ascending order.
        // Return “Wrong index!” for wrong indexes.



        // ---------------------------------------- My Solution ----------------------------------------
        public string GetLuckyTicket(int index)
        {
            if (index < 0 || index > 55250)
                return "Wrong index!";

            var lucky = new List<int>();
            foreach (var n in Enumerable.Range(0, 999999))
            {
                var num = n;
                var left = 0;
                var right = 0;
                for (int i = 0; i < 6; i++)
                {
                    if (i < 3)
                    {
                        right += num % 10;
                        num /= 10;
                    }
                    else
                    {
                        left += num % 10;
                        num /= 10;
                    }
                }


                if (left == right)
                {
                    lucky.Add(n);
                }
            }

            return lucky[index].ToString();
        }
        // Solved April 1, 2020



        // ---------------------------------------- Best Practices Solution on Codewars ----------------------------------------
        public class LuckyTicket
        {
            public static string GetLuckyTicket(int index)
            {
                int temp = 0;
                for (int i = 0; i < 1000000; i++)
                {
                    var ticket = i.ToString();
                    while (ticket.Length < 6) ticket = "0" + ticket;
                    if (IsLucky(ticket) && temp++ == index) return ticket;
                }
                return "Wrong index!";
            }

            private static bool IsLucky(string ticket)
            {
                return Convert(ticket[0]) + Convert(ticket[1]) + Convert(ticket[2]) == Convert(ticket[3]) + Convert(ticket[4]) + Convert(ticket[5]);
            }

            private static int Convert(char digit) => System.Convert.ToInt32(digit);
        }

    } // CW_AL_LuckyTicket class

} // CSharpPracticeExercises namespace
