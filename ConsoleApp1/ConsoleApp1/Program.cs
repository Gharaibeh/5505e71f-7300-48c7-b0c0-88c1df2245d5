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
            PositiveDivisors devisors = new PositiveDivisors();
            printResult(devisors.getNumberDivisors(20));
        }

        static void printResult(string output)
        {
            Console.WriteLine("The positive devisors re :\n" + output);
        }
    }
}
