using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class CW_S_WhoLikesIt
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Who likes it?

        // You probably know the "like" system from Facebook and other pages.
        // People can "like" blog posts, pictures or other items. 
        // We want to create the text that should be displayed next to such an item.

        // Implement a function likes :: [String] -> String, which must take in input array, containing the names of people who like an item.
        // It must return the display text as shown in the examples:
        // Kata.Likes(new string[0]) => "no one likes this"
        // Kata.Likes(new string[] {"Peter"}) => "Peter likes this"
        // Kata.Likes(new string[] {"Jacob", "Alex"}) => "Jacob and Alex like this"
        // Kata.Likes(new string[] {"Max", "John", "Mark"}) => "Max, John and Mark like this"
        // Kata.Likes(new string[] {"Alex", "Jacob", "Mark", "Max"}) => "Alex, Jacob and 2 others like this"

        // For 4 or more names, the number in and 2 others simply increases.



        // ---------------------------------------- My Solution ----------------------------------------
        public string Likes(string[] name)
        {
            switch (name.Length)
            {
                case 0:
                    return "no one likes this";
                case 1:
                    return $"{name[0]} likes this";
                case 2:
                    return $"{name[0]} and {name[1]} like this";
                case 3:
                    return $"{name[0]}, {name[1]} and {name[2]} like this";
                default:
                    var num = name.Length - 2;
                    return $"{name[0]}, {name[1]} and {num} others like this";
            }
        }
        // Solved March 23, 2020



        // ---------------------------------------- Best Practices Solution on Code Wars ----------------------------------------
        public static string LikesBest(string[] names)
        {
            switch (names.Length)
            {
                case 0: return "no one likes this"; // :(
                case 1: return $"{names[0]} likes this";
                case 2: return $"{names[0]} and {names[1]} like this";
                case 3: return $"{names[0]}, {names[1]} and {names[2]} like this";
                default: return $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
            }
        }
    }
}
