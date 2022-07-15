using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._02단계
{
    internal class _02_05
    {
        static void M1ain(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);

            if (a <= 0 && (b - 45) < 0)
            {
                a = 23;
                b = b + 15;
            }
            else if ((b - 45) < 0)
            {
                --a;
                b = b + 15;
            }
            else if ((b - 45) <= 0 && a <= 0)
            {
                a = 0;
                b = 0;
            }
            else
            {
                b = b - 45;
            }
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
