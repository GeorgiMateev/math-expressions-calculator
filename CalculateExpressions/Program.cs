using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateExpressions
{
    /// <summary>
    /// <copyright>
    ///     Georgi Mateev, 2012 http://www.georgi-mateev.com
    /// </copyright>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter expression (with only ln, pow and sqrt functions)");
            Console.WriteLine("You can use intervals and upper-lower case letters.");
            Console.WriteLine("Example:");
            Console.WriteLine("ln( Sqrt(36) )-(4+5)*pow(3,2)");
            string input = Console.ReadLine();

            double result = 0;
            try
            {
                result = CalculateExpressions.CalculateExpressionFromString(input);
                Console.WriteLine("Result: {0}", result);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }
    }
}
