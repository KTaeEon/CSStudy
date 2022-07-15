using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._02단계
{
    internal class _02_03
    {
        static void Mai1n(string[] args)
        {
            string str = Console.ReadLine();
            int i = int.Parse(str);

            if (i % 400 == 0)
            {
                Console.WriteLine("1");
            }
            else if (i % 100 == 0)
            {
                Console.WriteLine("0");
            }
            else if (i % 4 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
