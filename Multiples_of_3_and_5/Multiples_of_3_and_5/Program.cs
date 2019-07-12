using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiples of 3 and 5");
            Console.WriteLine("https://projecteuler.net/problem=1");
            int loop = 1000;
            int nilai1 = 3;
            int nilai2 = 5;
            int[] hasil = new int[loop];
            int i = 1;
            int a = 0;
            while (i < loop)
            {

                if (i % nilai1 == 0)
                {
                    hasil[a] = i;
                    a++;
                }
                else if (i % nilai2 == 0)
                {
                    hasil[a] = i;
                    a++;
                }
                i++;
            }
            int sum = 0;
            for (int ij = 0; ij < hasil.Length; ij++)
            {
                //Console.Write(hasil[ij] + ", ");
                sum += hasil[ij];
            }
            Console.WriteLine("Sum of all the multiples of 3 or 5 below 1000 is " + sum);
            Console.ReadLine();
        }
    }
}
