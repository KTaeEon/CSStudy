using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P107
    {
        static void Main1(string[] args)
        {
            var a = (int)10.0;
            var b = (float)10;
            var c = (double)10;

            // long 자료형을 int 자료형으로 변환합니다.
            long longNumber = 2147483647l + 2147483647l;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);
        }
    }
}
