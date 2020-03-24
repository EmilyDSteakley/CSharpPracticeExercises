using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class CW_M_VasyaClerk
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Vasya - Clerk

        // The new "Avengers" movie has just been released! 
        // There are a lot of people at the cinema box office standing in a huge line. 
        // Each of them has a single 100, 50 or 25 dollar bill. 
        // An "Avengers" ticket costs 25 dollars.

        // Vasya is currently working as a clerk.
        // He wants to sell a ticket to every single person in this line.

        // Can Vasya sell a ticket to every person and give change if he initially has no money and sells the tickets strictly in the order people queue?

        // Return YES, if Vasya can sell a ticket to every person and give change with the bills he has at hand at that moment.
        // Otherwise return NO.

        // Examples:
        // Line.Tickets(new int[] {25, 25, 50}) // => YES 
        // Line.Tickets(new int[] {25, 100}) // => NO. Vasya will not have enough money to give change to 100 dollars
        // Line.Tickets(new int[] {25, 25, 50, 50, 100}) // => NO. Vasya will not have the right bills to give 75 dollars of change (you can't make two bills of 25 from one of 50)



        // ---------------------------------------- My Solution ----------------------------------------
        public string Tickets(int[] peopleInLine)
        {
            var register = new Dictionary<int, int>();
            register.Add(25, 0);
            register.Add(50, 0);
            register.Add(100, 0);

            foreach (int bill in peopleInLine)
            {
                register[bill] += 1;
                switch (bill - 25)
                {
                    case 0:
                        continue;
                    case 25:
                        if (register[25] >= 1)
                            register[25] -= 1;
                        else
                            return "NO";
                        break;
                    case 50:
                        if (register[25] >= 2)
                            register[25] -= 2;
                        else if (register[50] >= 1)
                            register[50] -= 1;
                        else
                            return "NO";
                        break;
                    case 75:
                        if (register[50] == 0 && register[25] >= 3)
                            register[25] -= 3;
                        else if (register[50] >= 1 && register[25] >= 1)
                        {
                            register[50] -= 1;
                            register[25] -= 1;
                        }
                        else
                            return "NO";
                        break;
                }
            }
            return "YES";
        }
        // Solved March 23, 2020



        // ---------------------------------------- Best Practices Solution on Codewars ----------------------------------------
        public static string TicketsBest(int[] peopleInLine)
        {
            int twentyFives = 0, fifties = 0;

            foreach (var bill in peopleInLine)
            {
                switch (bill)
                {
                    case 25:
                        ++twentyFives;
                        break;
                    case 50:
                        --twentyFives;
                        ++fifties;
                        break;
                    case 100:
                        if (fifties == 0)
                        {
                            twentyFives -= 3;
                        }
                        else
                        {
                            --twentyFives;
                            --fifties;
                        }
                        break;
                }

                if (twentyFives < 0 || fifties < 0)
                {
                    return "NO";
                }
            }

            return "YES";
        }

    } // CW_M_VasyaClerk class

} // CSharpPracticeExercises namespace
