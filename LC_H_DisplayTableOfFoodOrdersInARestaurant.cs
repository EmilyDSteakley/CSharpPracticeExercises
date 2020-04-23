using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_H_DisplayTableOfFoodOrdersInARestaurant
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 1418. Display Table of Food Orders in a Restaurant
        // Given the array orders, which represents the orders that customers have done in a restaurant.
        // More specifically orders[i]=[customerNamei, tableNumberi, foodItemi] where customerNamei is the name of the customer, 
        // tableNumberi is the table customer sit at, and foodItemi is the item customer orders.


        // Return the restaurant's “display table”. 
        // The “display table” is a table whose row entries denote how many of each food item each table ordered. 
        // The first column is the table number and the remaining columns correspond to each food item in alphabetical order. 
        // The first row should be a header whose first column is “Table”, followed by the names of the food items. 
        // Note that the customer names are not part of the table. Additionally, the rows should be sorted in numerically increasing order.

        // Example 1:
        // Input: orders = [["David", "3", "Ceviche"], ["Corina","10","Beef Burrito"], ["David","3","Fried Chicken"], ["Carla","5","Water"], ["Carla","5","Ceviche"], ["Rous","3","Ceviche"]]
        // Output: [["Table","Beef Burrito","Ceviche","Fried Chicken","Water"],["3","0","2","1","0"],["5","0","1","0","1"],["10","1","0","0","0"]] 
        // Explanation:
        // The displaying table looks like:
        //      Table,Beef Burrito, Ceviche, Fried Chicken,Water
        //      3    ,0           ,2      ,1            ,0
        //      5    ,0           ,1      ,0            ,1
        //      10   ,1           ,0      ,0            ,0
        // For the table 3: David orders "Ceviche" and "Fried Chicken", and Rous orders "Ceviche".
        // For the table 5: Carla orders "Water" and "Ceviche".
        // For the table 10: Corina orders "Beef Burrito". 

        // Example 2:
        // Input: orders = [["James","12","Fried Chicken"],["Ratesh","12","Fried Chicken"],["Amadeus","12","Fried Chicken"],["Adam","1","Canadian Waffles"],["Brianna","1","Canadian Waffles"]]
        // Output: [["Table","Canadian Waffles","Fried Chicken"],["1","2","0"],["12","0","3"]] 
        // Explanation: 
        // For the table 1: Adam and Brianna order "Canadian Waffles".
        // For the table 12: James, Ratesh and Amadeus order "Fried Chicken".

        // Example 3:
        // Input: orders = [["Laura","2","Bean Burrito"],["Jhon","2","Beef Burrito"],["Melissa","2","Soda"]]
        // Output: [["Table","Bean Burrito","Beef Burrito","Soda"],["2","1","1","1"]]

        // Constraints:
        //  - 1 <= orders.length <= 5 * 10^4
        //  - orders[i].length == 3
        //  - 1 <= customerNamei.length, foodItemi.length <= 20
        //  - customerNamei and foodItemi consist of lowercase and uppercase English letters and the space character.
        //  - tableNumberi is a valid integer between 1 and 500.



        // ---------------------------------------- My Solution ----------------------------------------
        public IList<IList<string>> DisplayTable(IList<IList<string>> orders)
        {
            var output = new List<IList<string>>();
            var uniqueTables = new HashSet<int>();
            var uniqueFoods = new HashSet<string>();
            foreach (var order in orders)
            {
                uniqueTables.Add(Convert.ToInt32(order[1]));
                uniqueFoods.Add(order[2]);
            }

            var tables = new int[uniqueTables.Count];
            uniqueTables.CopyTo(tables);
            Array.Sort(tables);
            var foods = new string[uniqueFoods.Count];
            uniqueFoods.CopyTo(foods);
            Array.Sort(foods, StringComparer.Ordinal);

            var columns = new List<string>() { "Table" };
            foreach (var food in foods)
                columns.Add(food);
            output.Add(columns);

            for (int i = 0; i < tables.Length; i++)
            {
                var temp = new List<string>() { tables[i].ToString() };
                for (int j = 0; j < foods.Length; j++)
                    temp.Add("0");

                foreach (var order in orders)
                {
                    if (order[1] == tables[i].ToString())
                    {
                        var count = temp[Array.IndexOf(foods, order[2]) + 1];
                        temp[Array.IndexOf(foods, order[2]) + 1] = (Convert.ToInt32(count) + 1).ToString();
                    }
                }

                output.Add(temp);
            }

            return output;
        }
        // 1548 ms <-- Beats 5.21%
        // Solved April 22, 2020



        // ---------------------------------------- 528 ms Solution on LeetCode ----------------------------------------
        public IList<IList<string>> DisplayTable528(IList<IList<string>> orders)
        {
            // customer => table
            HashSet<string> foods = new HashSet<string>();
            Dictionary<int, Dictionary<string, int>> tables = new Dictionary<int, Dictionary<string, int>>();

            foreach (IList<string> order in orders)
            {
                string customer = order[0];
                int table = int.Parse(order[1]);
                string food = order[2];

                if (!foods.Contains(food))
                {
                    foods.Add(food);
                }

                if (!tables.ContainsKey(table))
                {
                    tables[table] = new Dictionary<string, int>();
                }
                Dictionary<string, int> currentTable = tables[table];

                if (!currentTable.ContainsKey(food))
                {
                    currentTable[food] = 0;
                }
                currentTable[food]++;
            }

            string[] sortedFoods = foods.ToArray();
            // Array.Sort(sortedFoods, delegate(string a, string b) {
            //     return ToLower(a).CompareTo(ToLower(b));
            // });
            Array.Sort(sortedFoods, delegate (string a, string b) {
                int i = 0;
                int j = 0;
                while (i < a.Length && j < b.Length)
                {
                    if (a[i] != b[j])
                    {
                        return a[i].CompareTo(b[j]);
                    }
                    i++;
                    j++;
                }

                if (i >= a.Length && j >= b.Length)
                {
                    return 0;
                }
                else if (i >= a.Length)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            });

            IList<IList<string>> result = new List<IList<string>>();
            result.Add(new List<string>() { "Table" });

            foreach (string food in sortedFoods)
            {
                result[0].Add(food);
            }
            int[] sortedTables = tables.Keys.ToArray();
            Array.Sort(sortedTables);

            foreach (int table in sortedTables)
            {
                List<string> row = new List<string>() { table.ToString() };

                foreach (string food in sortedFoods)
                {
                    row.Add(tables[table].ContainsKey(food) ? tables[table][food].ToString() : "0");
                }

                result.Add(row);
            }

            return result;
        }

        public string ToLower(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c >= 'A' && c <= 'Z')
                {
                    c = (char)((int)c - 'A' + 'a');
                }
                sb.Append(c);
            }

            return sb.ToString();
        }
    }
}
