using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P96
    {
        static void Main1123(string[] args)
        {
            int number = 10;
            Console.WriteLine(number++);
            Console.WriteLine(++number);
            Console.WriteLine(number--);
            Console.WriteLine(--number);

            int num1 = 10;
            Console.WriteLine(num1);
            num1++;
            num1++;
            Console.WriteLine(num1);
            Console.WriteLine(num1);
            num1--;
            num1--;
            Console.WriteLine(num1);
        }
    }
}
