using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001st_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10001st prime");
            Console.WriteLine("https://projecteuler.net/problem=7");
            Console.WriteLine("Please Input 10001 for the question");
            int num, i, f, a, list;
            Console.Write("Input number: ");
            list = Convert.ToInt32(Console.ReadLine());


            num = 2;
            a = 0;
            while (true)
            {
                f = 0;
                i = 2;
                while (i <= num / 2)
                {
                    if (num % i == 0)
                    {
                        f = 1;
                        break;
                    }
                    i++;
                }
                if (f == 0)
                {
                    a++;
                    if (a == list)
                    {
                        Console.WriteLine("Prime Number in list " + list + " is : " + num);
                        break;
                    }
                }
                num++;
            }
            Console.ReadLine();
        }
    }
}
