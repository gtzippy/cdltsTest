using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FunctionRepository;

namespace ArrayProblem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<int> list = null;
            Console.Clear();
            if (!args.Any())
            {
                Console.WriteLine("Please enter a valid comma deliniated list of 32 bit integers\nType -help for help");
                return;
            }
            if (args[0] == "-help")
            {
                
                ArrayProblemFunctions.HelpMessage();
                return;
            }
            if (!ArrayProblemFunctions.IsListValid(args[0]))
            {
                Console.WriteLine("Please enter a valid comma deliniated list of 32 bit integers\nType -help for help");
                Console.ReadLine();
                return;
            }
            list = args[0].Split(',').Select(int.Parse).ToList();
            if (args.Count() > 1)
            {
                int result;
                if (!int.TryParse(args[1], out result))
                {
                    Console.WriteLine(
                        "Please enter a valid 32 bit integer after the list to change the end of index count\nType -help for help");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine(ArrayProblemFunctions.GetNthFromEndEntry(list, Convert.ToInt16(args[1])));
            }
            else
            {
                Console.WriteLine(ArrayProblemFunctions.GetNthFromEndEntry(list));
            }
            Console.WriteLine("Press Enter To Exit");
            Console.ReadLine();
        }
    }
}
