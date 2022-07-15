using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._02단계
{
    internal class _02_06
    {
        static void Ma1in(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            string str1 = Console.ReadLine();

            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            int c = int.Parse(str1);

            b += c;

            while (b >= 60)
            {
                a++;
                b -= 60;
            }
            if ( a >= 24)
            {
                a -= 24;
            }
            Console.WriteLine("{0} {1}",a,b);

        }
    }
}
