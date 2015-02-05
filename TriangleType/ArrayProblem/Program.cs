using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> testList = new List<int> {1, 2, 3, 8, 5, 6};
            Console.WriteLine(GetNthFromLast(testList,5));
            Console.WriteLine(CantCountSolution(testList, 5));
            
            Console.ReadLine();
        }


        private static string CantCountSolution(List<int> list, int nth=5)
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
                    if (lastEntry < nth-1)
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    lastEntry--;             //every time we go beyond the list index we hit an exception that decriments the lastEntry
                }
            }
            
            return list[lastEntry - (nth-1)].ToString();
        }


        private static string GetNthFromLast(List<int> list, int nth=5)
        {
            

            ConcreteQueue<int> myQueue = new ConcreteQueue<int> {maxSize = nth};
            if (nth <= 0)
            {
                return "Invalid Input: Please enter an integer greater than '0'";
            }
            int result;
            if (list.Count() < nth)
            {
                throw new Exception("List not long enough");
            }
            foreach (int entry in list)
            {
                myQueue.Enqueue(entry);
            }
            myQueue.queue.TryPeek(out result);
            
            return result.ToString();
        }
    }
}
