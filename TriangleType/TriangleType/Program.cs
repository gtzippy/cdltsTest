using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriangleType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(triType(0, 2, 2));
            Console.ReadLine();
        }

        static string triType(int side1, int side2, int side3)
        {
            List<int> sides = new List<int> {side1, side2, side3};
            string triangleType = "Error: Invalid side lengths";
            if (sides.Any(x=>x<1))
            {
                return triangleType;
            }
            if (sides.Distinct().Count() == 1)
            {
                return "Equilateral";
            }
            if (sides.Distinct().Count() == 2)
            {
                return "Isosceles";
            }
            if (sides.Distinct().Count() == 3)
            {
                return "Scalene";
            }
            return triangleType;
        }
    }
}
