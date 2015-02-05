using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionRepository
{
    public class ArrayProblemFunctions
    {
        public static string GetNthFromEndEntry(List<int> list, int nth = 5)
        {
            if (nth <= 0)
            {
                return "Invalid Input: Please enter an integer greater than '0'";
            }
            int lastEntry = 0;
            while (true)
            {
                try
                {
                    int placeholder = (list[lastEntry]);     //operation that will cause us to hit the exeption and fall out once we get 
                    lastEntry = lastEntry + nth;             //to an index longer that the length of the list
                }
                catch (Exception e)
                {
                    break;
                }
            }

            lastEntry--;

            for (int i = 0; i < nth; i++)
            {
                try
                {
                    int placeholder = (list[lastEntry]);
                    if (lastEntry < nth - 1)
                    {
                        return new StringBuilder().AppendFormat("List not long enough, must contain at least {0} entires", nth).ToString();
                    }
                }
                catch (Exception e)
                {
                    lastEntry--;             //every time we go beyond the list index we hit an exception that decriments the lastEntry
                }
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{0} is {1} entries from the end of the array", list[lastEntry - (nth - 1)], nth);
            return stringBuilder.ToString();
        }

        public static bool IsListValid(string inputList)
        {
            int result = 0;
            List<string> list = inputList.Split(',').ToList();
            return list.All(entry => int.TryParse(entry, out result));
        }

        public static void HelpMessage()
        {
            Console.WriteLine("Enter a list of integers separated my commas in the style of:\n'1,2,3,4,5,6,7'");
            Console.WriteLine("You may follow that list with another positive integer to return the Nth term from the end of the array\nThe Dafualt value is 5");
        }
    }
}
