using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._02단계
{
    internal class _02_07
    {
        static void Ma1in(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            int c = int.Parse(str[2]);
            int res = 0;
            bool state = false;

            if( a == b && b == c)
            {
                res = 10000 + (a*1000);
            }
            else if ( a != b && c != b && a != c)
            {
                res = St(a, b, c) * 100;
            }
            else if (a == b)
            {
                res = 1000 + (a * 100);
            }
            else if (c == b)
            {
                res = 1000 + (c * 100);
            }
            else if (a == c)
            {
                res = 1000 + (a * 100);
            }
            Console.WriteLine(res);
        }


        public static int St(int i,int j,int k)
        {
            int n = i;
            if (n < j)
            {
                n = j;
            }
            if (n < k)
            {
                n = k;
            }
            return n;
        }
    }
}
