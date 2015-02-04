using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PrimeFactorization
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> numbersString;
            if (!args.Any())  //if you run the exe by clicking then you wont have an input
            {
                //args = new string[] {Environment.CurrentDirectory + "\\test1.txt"};
                Console.WriteLine("Please drag txt file onto icon or use the command line to specify a target file to run program \nPress Enter To Continue");
                Console.ReadLine();
                return;
            }
            if (Path.GetExtension(args[0]) != ".txt")    //only work with .txt files
            {
                Console.WriteLine("Please Select a File With the '.txt' Extension \nPress Enter To Continue");
                Console.ReadLine();
                return;
            }
            try   //try to read the sepecified file
            {
                numbersString = File.ReadLines(args[0]);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File Not Found.  Please Enter a Valid File \nPress Enter To Continue"); //Inform the user their file was not found at the specified locaton
                return;
            }

            numbersString = numbersString.Where(entry => !string.IsNullOrWhiteSpace(entry));    //remove empty entries caused by empty lines
            if (numbersString.Any(entry => !FunctionRepository.CheckStringValue(entry)))
            {
                Console.WriteLine("All values in .txt file must be integers.  Please reference your file for non-integer values \nPress Enter To Continue");
                Console.ReadLine();
                return;
            }

            List<int> numbers = numbersString.Select(int.Parse).ToList();  //create list of ints from list of strings from file

            foreach (int number in numbers)
            {
                Console.WriteLine(FunctionRepository.BuildOutputString(number));

            }
            Console.WriteLine("\nPress Enter To Continue");
            Console.ReadLine();
        }
    }
}
