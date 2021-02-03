using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PositiveDivisors
    {

        public PositiveDivisors()
        {

        }
      
        public bool IsPrime(int n)
        {
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int x = 3; x * x <= n; x += 2)
                if (n % x == 0)
                    return false;

            return true;
        }
        public string returnDivisors(int n)
        {
            List<int> divisors = new List<int>();

            if (n < 2)
            {
                return null;
            }
            else if (IsPrime(n))
            {
                return null;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                    if (n % i == 0)
                        divisors.Add(i);
            }

            StringBuilder _devisors = new StringBuilder();
            foreach (int div in divisors)
                _devisors.Append(div+" ");
            return _devisors.ToString();
        }
    }
}
