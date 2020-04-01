using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class Program
    {
        static void Main(string[] args)
        {






            #region Solved Problems

            //// Lucky Ticket
            //Console.WriteLine("Lucky Ticket");
            //var getLuckyTicket = new CW_AL_LuckyTicket();
            //Console.WriteLine($"Example 1: {getLuckyTicket.GetLuckyTicket(32683)}"); // 581077
            //Console.WriteLine($"Example 1: {getLuckyTicket.GetLuckyTicket(30610)}"); // 528287
            //Console.WriteLine($"Example 1: {getLuckyTicket.GetLuckyTicket(28758)}"); // 520007
            //// Solved April 1, 2020
            

            //// Greed is Good
            //Console.WriteLine("Greed is Good");
            //var score = new CW_AL_GreedIsGood();
            //Console.WriteLine($"Example 1: {score.Score(new[] { 5, 1, 3, 4, 1 })}"); // 250
            //Console.WriteLine($"Example 2: {score.Score(new[] { 1, 1, 1, 3, 1 })}"); // 1100
            //Console.WriteLine($"Example 3: {score.Score(new[] { 2, 4, 4, 5, 4 })}"); // 450
            //// Solved April 1, 2020


            //// Take a Number And Sum Its Digits Raised To The Consecutive Powers And ....¡Eureka!!
            //Console.WriteLine("Take a Number And Sum Its Digits Raised To The Consecutive Powers And ....¡Eureka!!");
            //var sumDigPow = new CW_M_TakeANumberAndSumItsDigitsRaisedToTheConsecutivePowers();
            //Console.Write("Example 1: ");
            //PrintArray(sumDigPow.SumDigPow(1, 10)); // [1, 2, 3, 4, 5, 6, 7, 8, 9]
            //Console.Write("Example 2: ");
            //PrintArray(sumDigPow.SumDigPow(1, 100)); // [1, 2, 3, 4, 5, 6, 7, 8, 9, 89]
            //Console.Write("Example 3: ");
            //PrintArray(sumDigPow.SumDigPow(90, 100)); // []
            //Console.Write("Example 4: ");
            //PrintArray(sumDigPow.SumDigPow(50, 150)); // [89, 135]
            //// Solved March 31, 2020


            //// RGB To Hex Conversion
            //Console.WriteLine("RGB To Hex Conversion");
            //var rgb = new CW_AL_RGBToHexConversion();
            //Console.WriteLine($"Example 1: {rgb.Rgb(255, 255, 255)}"); // FFFFFF
            //Console.WriteLine($"Example 2: {rgb.Rgb(255, 255, 300)}"); // FFFFFF
            //Console.WriteLine($"Example 3: {rgb.Rgb(0, 0, 0)}"); // 000000
            //Console.WriteLine($"Example 4: {rgb.Rgb(148, 0, 211)}"); // 9400D3
            //// Solved March 30, 2020


            //// 707. Design Linked List
            //Console.WriteLine("707. Design Linked List");
            //MyLinkedList linkedList = new MyLinkedList(); // Initialize empty LinkedList
            //linkedList.AddAtHead(1);
            //linkedList.PrintLinkedList();
            //linkedList.AddAtTail(3);
            //linkedList.PrintLinkedList();
            //linkedList.AddAtIndex(1, 2);                  // linked list becomes 1->2->3
            //Console.WriteLine(linkedList.Get(1));         // returns 2
            //linkedList.DeleteAtIndex(1);                  // now the linked list is 1->3
            //Console.WriteLine(linkedList.Get(1));         // returns 3
            //// Solved March 30, 2020


            //// Split Array Into Two Equal Sums
            //Console.WriteLine("Split Array Into Two Equal Sums");
            //var splitArray = new Interview_SplitArrayIntoTwoEqualSums();
            //Console.WriteLine($"Example 1: {splitArray.SplitArray(new[] { 2, 4, 4, 5, 5 })}"); // 3
            //Console.WriteLine($"Example 2: {splitArray.SplitArray(new[] { 1, 1, 2, 2 })}"); // -1
            //Console.WriteLine($"Example 3: {splitArray.SplitArray(new[] { -2, -4, -4, -5, -5 })}"); // 3
            //Console.WriteLine($"Example 4: {splitArray.SplitArray(new[] { 2, 4, 4, 1, 2, 3, 2, 5, 5 })}"); // -1
            //Console.WriteLine($"Example 5: {splitArray.SplitArray(new[] { 2, 4, 4, 1, 2, 1, 2, 5, 5 })}"); // 5
            //Console.WriteLine($"Example 6: {splitArray.SplitArray(new[] { 2, 2, -6, -3, 4, -3 })}"); // 3
            //Console.WriteLine($"Example 6: {splitArray.SplitArray(new[] { 5, 1, 1, 1, 1, 1 })}"); // 1
            //Console.WriteLine("\nSplit Array Into Two Equal Sums (Complete)");
            //Console.WriteLine($"Example 1: {splitArray.SplitArrayComplete(new[] { 2, 4, 4, 5, 5 })}"); // 3
            //Console.WriteLine($"Example 2: {splitArray.SplitArrayComplete(new[] { 1, 1, 2, 2 })}"); // -1
            //Console.WriteLine($"Example 3: {splitArray.SplitArrayComplete(new[] { -2, -4, -4, -5, -5 })}"); // 3
            //Console.WriteLine($"Example 4: {splitArray.SplitArrayComplete(new[] { 2, 4, 4, 1, 2, 3, 2, 5, 5 })}"); // -1
            //Console.WriteLine($"Example 5: {splitArray.SplitArrayComplete(new[] { 2, 4, 4, 1, 2, 1, 2, 5, 5 })}"); // 5
            //Console.WriteLine($"Example 6: {splitArray.SplitArrayComplete(new[] { 2, 2, -6, -3, 4, -3 })}"); // 3
            //Console.WriteLine($"Example 6: {splitArray.SplitArrayComplete(new[] { 5, 1, 1, 1, 1, 1 })}"); // 1
            //// Solved March 30, 2020


            //// Reverse Words In String
            //Console.WriteLine("Reverse Words In String");
            //var reverseWords = new Interview_ReverseWordsInString();
            //Console.Write($"Example 1: ");
            //reverseWords.ReverseWords("I love to code");
            //Console.Write($"Example 1 (No Split): ");
            //reverseWords.ReverseWordsNoSplit("I love to code");
            //// Solved March 30, 2020


            //// 5370. Design Underground System
            //Console.WriteLine("5370. Design Underground System");
            //Console.WriteLine("Example 1:");
            //UndergroundSystem undergroundSystem = new UndergroundSystem();
            //undergroundSystem.CheckIn(45, "Leyton", 3);
            //undergroundSystem.CheckIn(32, "Paradise", 8);
            //undergroundSystem.CheckIn(27, "Leyton", 10);
            //undergroundSystem.CheckOut(45, "Waterloo", 15);
            //undergroundSystem.CheckOut(27, "Waterloo", 20);
            //undergroundSystem.CheckOut(32, "Cambridge", 22);
            //Console.WriteLine(undergroundSystem.GetAverageTime("Paradise", "Cambridge")); // 14
            //Console.WriteLine(undergroundSystem.GetAverageTime("Leyton", "Waterloo")); // 11
            //undergroundSystem.CheckIn(10, "Leyton", 24);
            //Console.WriteLine(undergroundSystem.GetAverageTime("Leyton", "Waterloo")); // 11
            //undergroundSystem.CheckOut(10, "Waterloo", 38);
            //Console.WriteLine(undergroundSystem.GetAverageTime("Leyton", "Waterloo")); // 12
            //// Solved March 28, 2020


            //// 5369. Count Number of Teams
            //Console.WriteLine("5369. Count Number of Teams");
            //var numTeams = new LC_A_CountNumberOfTeams();
            //Console.WriteLine($"Example 1: {numTeams.NumTeams(new int[] { 2, 5, 3, 4, 1 })}"); // 3
            //Console.WriteLine($"Example 2: {numTeams.NumTeams(new int[] { 2, 1, 3 })}"); // 0
            //Console.WriteLine($"Example 3: {numTeams.NumTeams(new int[] { 1, 2, 3, 4 })}"); // 4
            //// Solved March 28, 2020


            //// 1394. Find Lucky Integer in an Array
            //Console.WriteLine("1394. Find Lucky Integer in an Array");
            //var findLucky = new LC_A_FindLuckyIntegerInAnArray();
            //Console.WriteLine($"Example 1: {findLucky.FindLucky(new int[] { 2, 2, 3, 4 })}"); // 2
            //Console.WriteLine($"Example 2: {findLucky.FindLucky(new int[] { 1, 2, 2, 3, 3, 3 })}"); // 3
            //Console.WriteLine($"Example 3: {findLucky.FindLucky(new int[] { 2, 2, 2, 3, 3 })}"); // -1
            //Console.WriteLine($"Example 4: {findLucky.FindLucky(new int[] { 5 })}"); // -1
            //Console.WriteLine($"Example 5: {findLucky.FindLucky(new int[] { 7, 7, 7, 7, 7, 7, 7 })}"); // 7
            //// Solved March 28, 2020


            ////Josephus Survivor
            //Console.WriteLine("Josephus Survivor");
            //var josSurvivor = new CW_M_JoshephusSurvivor();
            //Console.WriteLine($"Example 1: {josSurvivor.JosSurvivor(7, 3)}"); // 4
            //Console.WriteLine($"Example 2: {josSurvivor.JosSurvivor(11, 19)}"); // 10
            //Console.WriteLine($"Example 3: {josSurvivor.JosSurvivor(40, 3)}"); // 28
            //Console.WriteLine($"Example 4: {josSurvivor.JosSurvivor(100, 1)}"); // 100
            //Console.WriteLine($"Example 5: {josSurvivor.JosSurvivor(5, 300)}"); // 1
            //Console.WriteLine($"Example 6: {josSurvivor.JosSurvivor(300, 300)}"); // 265
            ////Solved March 26, 2020


            //// Josephus Permutation
            //Console.WriteLine("Josephus Permutation");
            //var josephus = new CW_M_JosephusPermutation();
            //Console.Write($"Example 1: ");
            //PrintList(josephus.JosephusPermutation(new List<object> { 1, 2, 3, 4, 5, 6, 7 }, 3));
            //Console.Write($"Example 2: ");
            //PrintList(josephus.JosephusPermutation(new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1));
            //// Solved March 24, 2020


            //// Tic-Tac-Toe Checker
            //Console.WriteLine("Tic-Tac-Toe Checker");
            //var isSolved = new CW_A_TicTacToeChecker();
            //Console.WriteLine($"Example 1: {isSolved.IsSolved(new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } })}"); // 1
            //Console.WriteLine($"Example 2: {isSolved.IsSolved(new int[,] { { 0, 0, 1 }, { 0, 1, 2 }, { 2, 1, 0 } })}"); // -1
            //Console.WriteLine($"Example 3: {isSolved.IsSolved(new int[,] { { 2, 1, 1 }, { 1, 2, 0 }, { 2, 1, 2 } })}"); // 2
            //Console.WriteLine($"Example 4: {isSolved.IsSolved(new int[,] { { 1, 1, 2 }, { 2, 2, 1 }, { 1, 1, 2 } })}"); // 0
            //// Solved March 23, 2020


            //// Vasya - Clerk
            //Console.WriteLine("Vasya - Clerk");
            //var line = new CW_M_VasyaClerk();
            //Console.WriteLine($"Example 1: {line.Tickets(new int[] { 25, 25, 50 })}");
            //Console.WriteLine($"Example 2: {line.Tickets(new int[] { 25, 100 })}");
            //Console.WriteLine($"Example 3: {line.Tickets(new int[] { 25, 25, 50, 50, 100 })}");
            //// Solved March 23, 2020


            //// Duplicate Encoder
            //Console.WriteLine("Duplicate Encoder");
            //var duplicateEncoder = new CW_S_DuplicateEncoder();
            //Console.WriteLine($"Example 1: {duplicateEncoder.DuplicateEncoder("din")}");
            //Console.WriteLine($"Example 1: {duplicateEncoder.DuplicateEncoder("recede")}");
            //Console.WriteLine($"Example 1: {duplicateEncoder.DuplicateEncoder("Success")}");
            //Console.WriteLine($"Example 1: {duplicateEncoder.DuplicateEncoder("(( @")}");
            //// Solved March 23, 2020


            //// Sum of Digits / Digital Root
            //Console.WriteLine("Sum of Digits / Digital Root");
            //var digitalRoot = new CW_M_SumOfDigitsDigitalRoot();
            //Console.WriteLine($"Example 1: {digitalRoot.DigitalRoot(16)}");
            //Console.WriteLine($"Example 2: {digitalRoot.DigitalRoot(942)}");
            //Console.WriteLine($"Example 3: {digitalRoot.DigitalRoot(132189)}");
            //Console.WriteLine($"Example 4: {digitalRoot.DigitalRoot(493193)}");
            //// Solved March 23, 2020


            //// Simple Encryption #1 - Alternating Split
            //Console.WriteLine("Simple Encryption #1 - Alternating Split");
            //var simple1 = new CW_S_SimpleEncryption1AlternatingSplit();
            //Console.WriteLine($"Example 1: {simple1.Encrypt("This is a test!", 1)}");
            //Console.WriteLine($"Example 1: {simple1.Decrypt("hsi  etTi sats!", 1)}");
            //Console.WriteLine($"Example 2: {simple1.Encrypt("This is a test!", 2)}");
            //Console.WriteLine($"Example 2: {simple1.Decrypt("s eT ashi tist!", 2)}");
            //// Solved March 23, 2020

            //// Binary Addition
            //Console.WriteLine("Binary Addition");
            //var addBinary = new CW_B_BinaryAddition();
            //Console.WriteLine($"Example 1: {addBinary.AddBinary(1, 2)}");
            //Console.WriteLine($"Example 2: {addBinary.AddBinary(42475, 6553)}");
            //Console.WriteLine($"Example 3: {addBinary.AddBinary(30514, 12803)}");
            //// Solved March 23, 2020


            //// Counting Duplicates
            //Console.WriteLine("Counting Duplicates");
            //var duplicateCount = new CW_S_CountingDuplicates();
            //Console.WriteLine($"Example 1: {duplicateCount.DuplicateCount("abcde")}");
            //Console.WriteLine($"Example 2: {duplicateCount.DuplicateCount("aabbcde")}");
            //Console.WriteLine($"Example 3: {duplicateCount.DuplicateCount("aabBcde")}");
            //Console.WriteLine($"Example 4: {duplicateCount.DuplicateCount("indivisibility")}");
            //Console.WriteLine($"Example 5: {duplicateCount.DuplicateCount("Indivisibilities")}");
            //Console.WriteLine($"Example 6: {duplicateCount.DuplicateCount("aA11")}");
            //Console.WriteLine($"Example 7: {duplicateCount.DuplicateCount("ABBA")}");
            //// Solved March 23, 2020


            //// Who likes it?
            //Console.WriteLine("Who likes it?");
            //var likes = new CW_S_WhoLikesIt();
            //Console.WriteLine($"Example 1: {likes.Likes(new string[0])}");
            //Console.WriteLine($"Example 2: {likes.Likes(new string[] { "Peter" })}");
            //Console.WriteLine($"Example 3: {likes.Likes(new string[] { "Jacob", "Alex" })}");
            //Console.WriteLine($"Example 4: {likes.Likes(new string[] { "Max", "John", "Mark" })}");
            //Console.WriteLine($"Example 5: {likes.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" })}");
            //// Solved March 23, 2020


            //// 2D Array - DS
            //Console.WriteLine("2D Array - DS");
            //var hourglassSum = new HR_A_2DArrayDS();
            //var hourglassTest1 = new int[6][];
            //hourglassTest1[0] = new[] { 1, 1, 1, 0, 0, 0 };
            //hourglassTest1[1] = new[] { 0, 1, 0, 0, 0, 0 };
            //hourglassTest1[2] = new[] { 1, 1, 1, 0, 0, 0 };
            //hourglassTest1[3] = new[] { 0, 0, 0, 0, 0, 0 };
            //hourglassTest1[4] = new[] { 0, 0, 0, 0, 0, 0 };
            //hourglassTest1[5] = new[] { 0, 0, 0, 0, 0, 0 };
            //Console.WriteLine($"Example 1: {hourglassSum.HourglassSum(hourglassTest1)}");
            //var hourglassTest2 = new int[6][];
            //hourglassTest2[0] = new[] { 1, 1, 1, 0, 0, 0 };
            //hourglassTest2[1] = new[] { 0, 1, 0, 0, 0, 0 };
            //hourglassTest2[2] = new[] { 1, 1, 1, 0, 0, 0 };
            //hourglassTest2[3] = new[] { 0, 0, 2, 4, 4, 0 };
            //hourglassTest2[4] = new[] { 0, 0, 0, 2, 0, 0 };
            //hourglassTest2[5] = new[] { 0, 0, 1, 2, 4, 0 };
            //Console.WriteLine($"Example 2: {hourglassSum.HourglassSum(hourglassTest2)}");
            //var hourglassTest3 = new int[6][];
            //hourglassTest3[0] = new[] { -1, -1, 0, -9, -2, -2 };
            //hourglassTest3[1] = new[] { -2, -1, -6, -8, -2, -5 };
            //hourglassTest3[2] = new[] { -1, -1, -1, -2, -3, -4 };
            //hourglassTest3[3] = new[] { -1, -9, -2, -4, -4, -5 };
            //hourglassTest3[4] = new[] { -7, -3, -3, -2, -9, -9 };
            //hourglassTest3[5] = new[] { -1, -3, -1, -2, -4, -5 };
            //Console.WriteLine($"Example 3: {hourglassSum.HourglassSum(hourglassTest3)}");
            //// Solved March 19, 2020


            //// Jaden Casing Strings
            //Console.WriteLine("Jaden Casing Strings");
            //var jadenCase = new CW_S_JadenCasingStrings();
            //Console.WriteLine(jadenCase.ToJadenCase("How can mirrors be real if our eyes aren't real"));
            //// Solved March 18, 2020


            //// 1381. Design a Stack With Increment Operation
            //Console.WriteLine("1381. Design a Stack With Increment Operation");
            //var customStack = new LC_ST_DesignAStackWithIncrementOperation(3);
            //customStack.Push(1);
            //customStack.Push(2);
            //Console.WriteLine(customStack);
            //Console.WriteLine(customStack.Pop());
            //customStack.Push(2);
            //customStack.Push(3);
            //customStack.Push(4);
            //Console.WriteLine(customStack);
            //customStack.Increment(5, 100);
            //customStack.Increment(2, 100);
            //Console.WriteLine(customStack);
            //Console.WriteLine(customStack.Pop());
            //Console.WriteLine(customStack.Pop());
            //Console.WriteLine(customStack.Pop());
            //Console.WriteLine(customStack.Pop());
            //// Solved March 14, 2020


            //// 1380.Lucky Numbers in a Matrix
            //Console.WriteLine("1380. Lucky Numbers in a Matrix");
            //var luckyNumbers = new LC_A_LuckyNumbersInAMatrix();
            //var matrix1 = new int[3][];
            //matrix1[0] = new int[] { 3, 7, 8 };
            //matrix1[1] = new int[] { 9, 11, 13 };
            //matrix1[2] = new int[] { 15, 16, 17 };
            //Console.WriteLine($"Example 1: [{string.Join(", ", luckyNumbers.LuckyNumbers(matrix1))}]");

            //var matrix2 = new int[3][];
            //matrix2[0] = new int[] { 1, 10, 4, 2 };
            //matrix2[1] = new int[] { 9, 3, 8, 7 };
            //matrix2[2] = new int[] { 15, 16, 17, 12 };
            //Console.WriteLine($"Example 2: [{string.Join(", ", luckyNumbers.LuckyNumbers(matrix2))}]");
            //// Solved March 14, 2020


            //// 38. Count and Say
            //Console.WriteLine("38.Count and Say");
            //var countAndSay = new LC_S_CountAndSay();
            //Console.WriteLine($"Example 1: {countAndSay.CountAndSay(1)}");
            //Console.WriteLine($"Example 1: {countAndSay.CountAndSay(3)}");
            //Console.WriteLine($"Example 1: {countAndSay.CountAndSay(5)}");
            //// Solved March 13, 2020


            //// 905. Sort Array By Parity
            //Console.WriteLine("905. Sort Array By Parity");
            //var sortParity = new LC_A_SortArrayByParity();
            //Console.WriteLine($"Example 1: [{string.Join(", ", sortParity.SortArrayByParity(new[] { 3, 1, 2, 4 }))}]");
            //Console.WriteLine($"Example 2: [{string.Join(", ", sortParity.SortArrayByParity(new[] { 0, 1, 2 }))}]");
            //// Solved March 12, 2020


            //// 121. Best Time to Buy and Sell Stock
            //Console.WriteLine("121. Best Time to Buy and Sell Stock");
            //var maxProfit = new LC_A_BestTimeToBuyAndSellStock();
            //Console.WriteLine($"Example 1: {maxProfit.MaxProfit(new[] { 7, 1, 5, 3, 6, 4 })}");
            //Console.WriteLine($"Example 2: {maxProfit.MaxProfit(new[] { 7, 6, 4, 3, 1 })}");
            //Console.WriteLine($"Example 3: {maxProfit.MaxProfit(new[] { 1, 2 })}");
            //// Solved March 11, 2020


            //// 118. Pascal's Triangle
            //Console.WriteLine("118. Pascal's Triangle");
            //var generator = new LC_A_PascalsTriangle();
            //Console.WriteLine("Example 1:");
            //PrintNestedList(generator.Generate(5));
            //PrintJaggedArray(generator.Generate2(5));
            //// Solved March 11, 2020


            //// 202. Happy Number
            //Console.WriteLine("202. Happy Number");
            //var isHappy = new LC_M_HappyNumber();
            //Console.WriteLine($"Example 1: {isHappy.IsHappy32(19)}");
            //Console.WriteLine($"Example 2: {isHappy.IsHappy32(23)}");
            //Console.WriteLine($"Example 1: {isHappy.IsHappy32(47)}");
            //// Solved March 5, 2020


            //// 1160. Find Words That Can Be Formed by Characters
            //Console.WriteLine("1160. Find Words That Can Be Formed by Characters");
            //var countCharacters = new LC_A_FindWordsThatCanBeFormedByCharacters();
            //Console.WriteLine($"Example 1: {countCharacters.CountCharacters(new[] { "cat", "bt", "hat", "tree" }, "atach")}");
            //Console.WriteLine($"Example 2: {countCharacters.CountCharacters(new[] { "hello", "world", "leetcode" }, "welldonehoneyr")}");
            //// Solved March 5, 2020


            //// 1366. Rank Teams by Votes
            //Console.WriteLine("1366. Rank Teams by Votes");
            //var teamRanker = new LC_A_RankTeamsByVotes();
            //Console.WriteLine($"Example 1: {teamRanker.RankTeams(new[] { "ABC", "ACB", "ABC", "ACB", "ACB" })}");
            //Console.WriteLine($"Example 2: {teamRanker.RankTeams(new[] { "WXYZ", "XYZW" })}");
            //Console.WriteLine($"Example 3: {teamRanker.RankTeams(new[] { "ZMNAGUEDSJYLBOPHRQICWFXTVK" })}");
            //Console.WriteLine($"Example 4: {teamRanker.RankTeams(new[] { "BCA", "CAB", "CBA", "ABC", "ACB", "BAC" })}");
            //Console.WriteLine($"Example 5: {teamRanker.RankTeams(new[] { "M", "M", "M", "M" })}");
            //// Solved March 5, 2020


            //// 231. Power of Two
            //Console.WriteLine("// 231. Power of Two");
            //var twoPower = new LC_M_PowerOfTwo();
            //Console.WriteLine($"Example 1: {twoPower.IsPowerOfTwo(1)}");
            //Console.WriteLine($"Example 2: {twoPower.IsPowerOfTwo(16)}");
            //Console.WriteLine($"Example 3: {twoPower.IsPowerOfTwo(218)}");
            //// Solved March 2, 2020


            //// 1365. How Many Numbers Are Smaller Than the Current Number
            //Console.WriteLine("1365. How Many Numbers Are Smaller Than the Current Number");
            //var smallerNums = new LC_A_HowManyNumbersAreSmallerThanTheCurrentNumber();
            //Console.WriteLine($"Example 1: [{string.Join(", ", smallerNums.SmallerNumbersThanCurrent(new[] { 8, 1, 2, 2, 3 }))}]");
            //Console.WriteLine($"Example 2: [{string.Join(", ", smallerNums.SmallerNumbersThanCurrent(new[] { 6, 5, 4, 8 }))}]");
            //Console.WriteLine($"Example 3: [{string.Join(", ", smallerNums.SmallerNumbersThanCurrent(new[] { 7, 7, 7, 7 }))}]");
            //// Solved February 29, 2020


            //// Arrays - Left Rotation
            //Console.WriteLine("Arrays - Left Rotation");
            //var leftRot = new HR_A_LeftRotation();
            //Console.WriteLine($"Example 1: [{string.Join(", ", leftRot.RotLeft(new[] { 1, 2, 3, 4, 5 }, 4))}]");
            //Console.WriteLine($"Example 2: [{string.Join(", ", leftRot.RotLeft(new[] { 7, 9, 6, 2 }, 2))}]");
            //// Solved February 29, 2020

            //// 961. N-Repeated Element in Size 2N Array
            //Console.WriteLine("961. N-Repeated Element in Size 2N Array");
            //var nTimes = new LC_H_NRepeatedElementInSize2NArray();
            //Console.WriteLine($"Example 1: {nTimes.RepeatedNTimes(new[] { 1, 2, 3, 3 })}");
            //Console.WriteLine($"Example 2: {nTimes.RepeatedNTimes(new[] { 2, 1, 2, 5, 3, 2 })}");
            //Console.WriteLine($"Example 3: {nTimes.RepeatedNTimes(new[] { 5, 1, 5, 2, 5, 3, 4 })}\n\n");
            //// Solved February 28, 2020


            //// Warm-up Challenges - Counting Valleys
            //Console.WriteLine("Warm-up Challenges - Counting Valleys");
            //var valleyCounter = new HR_W_CountingValleys();
            //Console.WriteLine($"Example 1: {valleyCounter.countingValleys(8, "DDUUUUDD")}");
            //Console.WriteLine($"Example 2: {valleyCounter.countingValleys(8, "UDDDUDUU")}");
            //// Solved February 27, 2020


            //// Warm-up Challenges - Repeated String
            //Console.WriteLine("Warm-up Challenges - Repeated String");
            //var aCounter = new HR_W_RepeatedString();
            //Console.WriteLine($"Example 1: {aCounter.RepeatedString("aba", 10)}");
            //Console.WriteLine($"Example 2: {aCounter.RepeatedString("a", 1000000000000)}\n\n");
            //// Solved February 26, 2020


            //// 509. Fibonacci Number
            //Console.WriteLine("509. Fibonacci Number");
            //var fibonacci = new LC_A_FibonacciNumber();
            //Console.WriteLine($"Example 1: {fibonacci.Fib1(2)}");
            //Console.WriteLine($"Example 2: {fibonacci.Fib1(3)}");
            //Console.WriteLine($"Example 3: {fibonacci.Fib1(4)}");
            //Console.WriteLine($"Example 4: {fibonacci.Fib1(5)}\n\n");
            //// Solved February 25, 2020


            //// 1204. Find N Unique Integers Sum up to Zero
            //Console.WriteLine("1204. Find N Unique Integers Sum up to Zero");
            //var zeroSum = new LC_A_FindNUniqueIntegersSumUpToZero();
            //Console.WriteLine($"Example 1: [{string.Join(", ", zeroSum.SumZero(5))}]");
            //Console.WriteLine($"Example 2: [{string.Join(", ", zeroSum.SumZero(3))}]");
            //Console.WriteLine($"Example 3: [{string.Join(", ", zeroSum.SumZero(1))}]\n\n");
            //// Solved February 22, 2020


            //// Warm-up Challenges - Sock Merchant
            //Console.WriteLine("Warm-up Challenges - Sock Merchant");
            //var sockPairs = new HR_W_SockMerchant();
            //Console.WriteLine($"Example 1: {sockPairs.SockMerchant(7, new[] { 1, 2, 1, 2, 1, 3, 2 })}");
            //Console.WriteLine($"Example 2: {sockPairs.SockMerchant(9, new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 })}\n\n");
            //// Solved February 20, 2020


            //// 1323. Maximum 69 Number
            //Console.WriteLine("1323. Maximum 69 Number");
            //var maxNumChecker = new LC_M_Maximum69Number();
            //Console.WriteLine($"Example 1: {maxNumChecker.Maximum69Number(9669)}");
            //Console.WriteLine($"Example 2: {maxNumChecker.Maximum69Number(9996)}");
            //Console.WriteLine($"Example 3: {maxNumChecker.Maximum69Number(9999)}\n\n");
            //// Solved February 19, 2020


            //// 1. Two Sum
            //Console.WriteLine("1. Two Sum");
            //var findSum = new LC_A_TwoSum();
            //Console.WriteLine($"Example 1: [{string.Join(", ", findSum.TwoSum(new[] { 2, 7, 11, 15 }, 9))}]\n\n");


            //// 680. Valid Palindrome II
            //Console.WriteLine("680. Valid Palindrome II");
            //var paliCheck2 = new LC_S_ValidPalindromeII();
            //Console.WriteLine($"Example 1: {paliCheck2.ValidPalindrome("aba")}");
            //Console.WriteLine($"Example 2: {paliCheck2.ValidPalindrome("abca")}\n\n");
            //// Solved February 18, 2020


            //// 557. Reverse Words in a String III
            //Console.WriteLine("557. Reverse Words in a String III");
            //var reverseWordsInString = new LC_S_ReverseWordsInAStringIII();
            //Console.WriteLine($"Example 1: {reverseWordsInString.ReverseWords("Let's take LeetCode contest")}\n\n");
            //// Solved February 11, 2020


            //// 125. Valid Palindrome
            //Console.WriteLine("125. Valid Palindrome");
            //var paliCheck = new LC_S_ValidPalindrome();
            //Console.WriteLine($"Example 1: {paliCheck.IsPalindrome("A man, a plan, a canal: Panama")}");
            //Console.WriteLine($"Example 2: {paliCheck.IsPalindrome("race a car")}\n\n");
            //// Solved February 11, 2020


            //// 9. Palindrome Number
            //Console.WriteLine("9. Palindrome Number");
            //var numberChecker = new LC_M_PalindromeNumber();
            //Console.WriteLine($"Example 1: {numberChecker.IsPalindrome(121)}");
            //Console.WriteLine($"Example 2: {numberChecker.IsPalindrome(-121)}");
            //Console.WriteLine($"Example 3: {numberChecker.IsPalindrome(10)}\n\n");
            //// Solved Feburary 11, 2020


            //// 344. Reverse String
            //Console.WriteLine("344. Reverse String");
            //var stringReverser = new LC_S_ReverseString();
            //stringReverser.ReverseString(new[] { 'h', 'e', 'l', 'l', 'o' });
            //stringReverser.ReverseString(new[] { 'H', 'a', 'n', 'n', 'a', 'h' });
            //Console.WriteLine("\n");
            //// Solved February 10, 2020


            //// 1295. Find Numbers with Even Number of Digits
            //Console.WriteLine("1295. Find Numbers with Even Number of Digits");
            //var numberFinder = new LC_M_FindNumbersWithEvenNumberOfDigits();
            //Console.WriteLine($"Example 1: {numberFinder.FindNumbers(new int[] { 12, 345, 2, 6, 7896 })}");
            //Console.WriteLine($"Example 2: {numberFinder.FindNumbers(new int[] { 555, 901, 482, 1771 })}\n\n");
            //// Solved January 31, 2020


            //// 1281. Subtract the Product and Sum of Digits of an Integer
            //Console.WriteLine("1281. Subtract the Product and Sum of Digits of an Integer");
            //var productSumCalc = new LC_M_SubtractTheProductAndSumOfDigitsOfAnInteger();
            //Console.WriteLine($"Example 1: {productSumCalc.SubtractProductAndSum(234)}");
            //Console.WriteLine($"Example 2: {productSumCalc.SubtractProductAndSum(53252)}\n\n");
            //// Solved January 31, 2020

            #endregion

        } // Main method

        #region Print Methods

        public static void PrintJaggedArray<T>(T[][] jaggedArr)
        {
            for (int i = 0; i < jaggedArr.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write(jaggedArr[i][j] + " ");
                }
                Console.WriteLine();
            }
        } // PrintArray method

        public static void PrintNestedList(IList<IList<int>> nestedList)
        {
            for (int i = 0; i < nestedList.Count; i++)
            {
                for (int j = 0; j < nestedList[i].Count; j++)
                {
                    Console.Write(nestedList[i][j] + " ");
                }
                Console.WriteLine();
            }
        } // PrintNestedList method

        public static void PrintList(List<object> list)
        {
            Console.WriteLine($"[{string.Join(", ", list)}]");
        }

        public static void PrintArray<T>(T[] array)
        {
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        #endregion

    } // Program class

} // CSharpPracticeExercises namespace
