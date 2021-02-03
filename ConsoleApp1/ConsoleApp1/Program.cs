using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PositiveDivisors devisors = new PositiveDivisors();
                printResult(devisors.returnDivisors(60));
                printResult(devisors.returnDivisors(42));
                printResult(devisors.returnDivisors(100));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Print out the results
        /// </summary>
        /// <param name="output"></param>
        static void printResult(string output)
        {
            Console.WriteLine("The positive devisors are :\n" + output);
        }
    }
}
