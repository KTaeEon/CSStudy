using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._07단계
{
    internal class _07_07
    {
        static void Ma1in(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 10)
            {
                if (n % 5 == 0)
                {
                    Console.WriteLine(n / 5);
                }
                else if (n % 3 == 0)
                {
                    Console.WriteLine(n / 3);
                }
                else if (n % 5 == 3)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
            else
            {
                if ( n % 5 == 0)
                {
                    Console.WriteLine(n / 5);
                }
                else if ((n - 3) % 5 == 0)
                {
                    Console.WriteLine((n / 5)+ 1);
                }
                else if ((n - 6) % 5 == 0)
                {
                    Console.WriteLine((n / 5) + 1);
                }
                else if ((n - 9) % 5 == 0)
                {
                    Console.WriteLine((n / 5) + 2);
                }
                else if ((n - 12) % 5 == 0)
                {
                    Console.WriteLine((n / 5) + 2);
                }
            }
        }
    }
}
