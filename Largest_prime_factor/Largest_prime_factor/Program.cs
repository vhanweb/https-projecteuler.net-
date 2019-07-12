using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_prime_factor
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 0;
            Console.WriteLine("Largest prime factor");
            Console.WriteLine("https://projecteuler.net/problem=3");
            Console.WriteLine("Please Input 600851475143 for the question");
            Console.Write("Input the number: ");
            n = long.Parse(Console.ReadLine());
            Console.WriteLine("The largest prime factors of " + n + " are " + maxPrimeFactors(n));
            Console.ReadLine();
        }
        static long maxPrimeFactors(long n)
        {
            long maxPrime = -1;
            while (n % 2 == 0)
            {
                maxPrime = 2;
                n >>= 1;
            }
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    maxPrime = i;
                    n = n / i;
                }
            }

            if (n > 2)
                maxPrime = n;

            return maxPrime;
        }
    }
}
