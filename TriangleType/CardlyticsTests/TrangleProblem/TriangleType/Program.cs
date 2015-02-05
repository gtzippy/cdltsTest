using System;
using System.Collections.Generic;
using System.Text;
using FunctionRepository;

namespace TriangleType
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(TriangleFunctions.ValidInputs(args));
            Console.ReadLine();
        }
    }
}
