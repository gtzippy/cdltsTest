using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeFactorization
{
    public class FunctionRepository
    {
        /// <summary>
        /// Check to see if the string value from a line in the file is an integer
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool CheckStringValue(string value)
        {
            int result;
            return int.TryParse(value, out result);
        }

        /// <summary>
        /// Basic Sieve of Eratosthenes
        /// We check to see if our number is prime by doing a modulous check all the way up to the square root of the number.
        /// We don't have to go beyond the square root becasue if there are no factors below the square root their can be no factors
        /// above it and if the number has an integer square root then it is a perfect square and connot be prime.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number%i == 0) return false;
            }
            return true;
        }

        /// <summary>
        /// Build and return the comma-delimited list of prime factors and the product of the list
        /// </summary>
        /// <param name="inputNumber"></param>
        /// <returns></returns>
        public static string BuildOutputString(int inputNumber)
        {
            int number = inputNumber;
            if (number < 0)
            {
                return number + " negative numbers, by definition, cannot be prime";
            }

            switch (number)
            {
                case 0:
                    return number + " is a composite number with infinite divisors";
                case 1:
                    return number + " is not prime but has no divisors";
                default:
                    if (IsPrime(number))
                    {
                        return number + " is Prime";
                    }
                    List<int> primeFactors = new List<int>();
                    int counter = 2;
                    while (counter <= Math.Sqrt(number))
                    {
                        if (number%counter == 0)
                        {
                            number = number/counter;
                            if (number == counter && !IsPrime(number))
                                //handles cases of numbers only divisible by their square roots (like 4 and 9)
                            {
                                break;
                            }
                            if (IsPrime(number)) //only add prime factors to the list
                            {
                                primeFactors.Add(number);
                            }
                            if (IsPrime(counter))
                            {
                                primeFactors.Add(counter);
                            }
                        }
                        else
                        {
                            counter++;
                        }
                    }

                    primeFactors.Sort(); //sort in accending order
                    string resultString = string.Join(",", primeFactors); //build the string list
                    return resultString + " Product: " + ListProduct(primeFactors);
            }
            // + (ListProduct(primeFactors) == inputNumber);
        }

        /// <summary>
        /// Returns the product of all of the integers in a list
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private static int ListProduct(IEnumerable<int> list)
        {
            return list.Aggregate((current, number) => current*number);
        }
    }
}
