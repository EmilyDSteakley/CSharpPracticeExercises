using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_A_RankTeamsByVotes
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 1366. Rank Teams by Votes

        // In a special ranking system, each voter gives a rank from highest to lowest to all teams participated in the competition.

        // The ordering of teams is decided by who received the most position-one votes. 
        // If two or more teams tie in the first position, we consider the second position to resolve the conflict, if they tie again, we continue this process until the ties are resolved. 
        // If two or more teams are still tied after considering all positions, we rank them alphabetically based on their team letter.

        // Given an array of strings votes which is the votes of all voters in the ranking systems.Sort all teams according to the ranking system described above.
        // Return a string of all teams sorted by the ranking system.

        // Example 1:
        // Input: votes = ["ABC", "ACB", "ABC", "ACB", "ACB"]
        // Output: "ACB"
        // Explanation: Team A was ranked first place by 5 voters.No other team was voted as first place so team A is the first team.
        //              Team B was ranked second by 2 voters and was ranked third by 3 voters.
        //              Team C was ranked second by 3 voters and was ranked third by 2 voters.
        //              As most of the voters ranked C second, team C is the second team and team B is the third.

        // Example 2:
        // Input: votes = ["WXYZ", "XYZW"]
        // Output: "XWYZ"
        // Explanation: X is the winner due to tie-breaking rule. 
        //              X has same votes as W for the first position but X has one vote as second position while W doesn't have any votes as second position. 

        // Example 3:
        // Input: votes = ["ZMNAGUEDSJYLBOPHRQICWFXTVK"]
        // Output: "ZMNAGUEDSJYLBOPHRQICWFXTVK"
        // Explanation: Only one voter so his votes are used for the ranking.

        // Example 4:
        // Input: votes = ["BCA", "CAB", "CBA", "ABC", "ACB", "BAC"]
        // Output: "ABC"
        // Explanation: Team A was ranked first by 2 voters, second by 2 voters and third by 2 voters.
        //              Team B was ranked first by 2 voters, second by 2 voters and third by 2 voters.
        //              Team C was ranked first by 2 voters, second by 2 voters and third by 2 voters.
        //              There is a tie and we rank teams ascending by their IDs.

        // Example 5:
        // Input: votes = ["M", "M", "M", "M"]
        // Output: "M"
        // Explanation: Only team M in the competition so it has the first rank.

        // Constraints:
        //  - 1 <= votes.length <= 1000
        //  - 1 <= votes[i].length <= 26
        //  - votes[i].length == votes[j].length for 0 <= i, j < votes.length.
        //  - votes[i][j] is an English upper-case letter.
        //  - All characters of votes[i] are unique.
        //  - All the characters that occur in votes[0] also occur in votes[j] where 1 <= j < votes.length.



        // ---------------------------------------- My Solution ----------------------------------------
        public string RankTeams(string[] votes)
        {
            // If there is only 1 vote, return the vote
            if (votes.Length == 1)
                return votes[0].ToString();

            // Check constraints
            if (votes.Length == 0 || votes.Length > 1000 || votes[0].Length == 0 || votes[0].Length > 26)
                throw new ArgumentOutOfRangeException();

            // Number of Teams and Number of Places
            var numOfTeams = votes[0].Length;

            // Create a 2D array with size number of teams by number of teams
            var voteTally = new int[numOfTeams, numOfTeams];

            // Set the first vote as the template and sort as sortedTeams
            var template = votes[0];
            var sortedTeams = template.ToCharArray();
            Array.Sort(sortedTeams);

            //// Display sortedTeams
            //Console.WriteLine($"[{string.Join(", ", sortedTeams)}]");



            // Tally the number of times a team gets a vote for a rank and fill the voteTally array
            for (int i = 0; i < sortedTeams.Length; i++)
            {
                for (int j = 0; j < votes.Length; j++)
                {
                    voteTally[i, Array.IndexOf(votes[j].ToCharArray(), sortedTeams[i])]++;
                }
            }

            // Display voteTally
            PrintArray(voteTally);



            // Make each row a number string
            var numArr = new string[numOfTeams];
            var numStr = new StringBuilder();
            for (int i = 0; i < numOfTeams; i++)
            {
                for (int j = 0; j < numOfTeams; j++)
                {
                    numStr.Append(voteTally[i,j]);
                }
                numArr[i] = numStr.ToString();
                numStr.Clear();
            }

            // Display numArr
            Console.WriteLine($"[{string.Join(", ", numArr)}]");



            // Create a dictionary with the teams as keys and numbers as values
            var templateRank = new Dictionary<char, string>();
            for (int i = 0; i < numOfTeams; i++)
            {
                templateRank.Add(sortedTeams[i], numArr[i]);
            }

            // Display templateRank
            foreach (KeyValuePair<char, string> team in templateRank)
            {
                Console.WriteLine($"Key = {team.Key}, Value = {team.Value}");
            }

            // Sort templateRank by value in descending order and create a result string
            var result = new StringBuilder();
            foreach (KeyValuePair<char, string> team in templateRank.OrderByDescending(key => key.Value))
            {
                //Console.WriteLine($"Key = {team.Key}, Value = {team.Value}");
                result.Append(team.Key);
            }

            return result.ToString();
        }


        public static void PrintArray<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        // March 3, 2020
        // My solution of turning the tally row into a single number does not work when the tally excedes 10
        // No idea what to do now...



        // XX ms <-- Beats XX.XX%
        // Solved March XX, 2020



        // ---------------------------------------- 24 ms Solution on LeetCode ----------------------------------------


    } // LC_A_RankTeamsByVotes class

} // CSharpPracticeExercises namespace
