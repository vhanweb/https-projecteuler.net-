using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int length = 0;
            int x = 0;
            bool a = true;
            Console.WriteLine("Smallest multiple");
            Console.WriteLine("https://projecteuler.net/problem=5");

            Console.Write("You can input 20 for the question: ");
            length = Convert.ToInt32(Console.ReadLine());
            
            while (a)
            {
                n++;
                for (int i = 1; i <= length; i++)
                {
                    if (n % i == 0)
                    {
                        x++;
                        //Console.Write(x + ", ");
                    }
                }

                if (x == 10)
                {
                    a = false;
                }
                else
                {
                    x = 0;
                }

            }
            Console.WriteLine();
            Console.WriteLine("Nilai : " + n);
            Console.ReadLine();
        }
    }
}
