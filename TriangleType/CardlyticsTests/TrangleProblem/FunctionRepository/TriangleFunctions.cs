using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionRepository
{
    public class TriangleFunctions
    {
        public static string ValidInputs(string[] args)
        {
            if (!args.Any())
            {
                return "Please enter 3 valid positive integers";
            }
            if (args.Count() != 3)
            {
                return "Please enter ONLY 3 valid positive integers";
            }
            try
            {
                return (TriType(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), Convert.ToInt32(args[2])));
            }
            catch (FormatException e)
            {
                return "Please enter 3 valid positive integers: FormatException";
            }
            catch (OverflowException e)
            {
                return "Please enter 3 valid positive integers: OverflowException";
            }
        }

        public static string TriType(int side1, int side2, int side3)
        {
            List<int> sides = new List<int> { side1, side2, side3 };
            const string triangleType = "Error: Invalid side lengths";
            if (sides.Any(x => x < 1))
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
