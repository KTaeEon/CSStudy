using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._02단계
{
    internal class _02_04
    {
        static void Ma1in(string[] args)
        {
            string str = Console.ReadLine();
            string str1 = Console.ReadLine();

            int a = int.Parse(str);
            int b = int.Parse(str1);

            if ( a > 0 && b > 0 )
            {
                Console.WriteLine("1");
            }
            else if (a < 0 && b > 0)
            {
                Console.WriteLine("2");
            }
            else if (a > 0 && b < 0)
            {
                Console.WriteLine("4");
            }
            else if (a < 0 && b < 0)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("0");
            }
        }

    }
}
