using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._07단계
{
    internal class _07_04
    {
        static void Ma1in(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int v = int.Parse(arr[2]);
            int res = (v - a) / (a - b);
            if((v - a) % (a - b) != 0)
            {
                res += 1;
            }

            Console.WriteLine(res + 1 );
        }
    }
}
