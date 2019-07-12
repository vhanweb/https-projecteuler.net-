using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_square_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum square difference");
            Console.WriteLine("https://projecteuler.net/problem=6");

            Console.WriteLine("You can input 100 for the question ");
            double tot1, tot2, tot3, x;
            tot1 = 0;
            tot2 = 0;
            Console.Write("Input : ");
            x = Convert.ToInt32(Console.ReadLine());
            for (double i = 1; i <= x; i++)
            {
                tot1 = Math.Pow(i, 2) + tot1;
                tot2 = i + tot2;
            }
            tot2 = Math.Pow(tot2, 2);
            tot3 = tot2 - tot1;

            Console.Write("Hence the difference between the sum of the squares of the first " + x + " natural numbers and the square of the sum is " + tot2 + "−" + tot1 + " = " + tot3);
            Console.ReadLine();
        }
    }
}
