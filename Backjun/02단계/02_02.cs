using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._02단계
{
    internal class _02_02
    {
        static void Ma1in(string[] args)
        {
            string str = Console.ReadLine();

            int a = int.Parse(str);

            if (90 <= a)
            {
                Console.WriteLine("A");
            }
            else if (80 <= a)
            {
                Console.WriteLine("B");
            }
            else if (70 <= a)
            {
                Console.WriteLine("C");
            }
            else if (60 <= a)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
