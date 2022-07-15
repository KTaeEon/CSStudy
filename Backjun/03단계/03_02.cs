using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._03단계
{
    internal class _03_02
    {
        static void Ma1in(string[] args)
        {
            string str = Console.ReadLine();
            long a = int.Parse(str);

            for ( short i = 1; (a-i) >= 0; i++)
            {
                string[] str1 = Console.ReadLine().Split();
                short b = short.Parse(str1[0]);
                short c = short.Parse(str1[1]);
                Console.WriteLine(b + c);

            }
        }
    }
}
