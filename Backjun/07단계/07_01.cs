using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._07단계
{
    internal class _07_01
    {
        static void Mai1n(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int A = int.Parse(str[0]);
            int B = int.Parse(str[1]);
            int C = int.Parse(str[2]);

            if ((C - B) > 0)
            {
                Console.WriteLine((A / (C - B)) + 1);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
