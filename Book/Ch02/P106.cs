using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P106
    {
        static void Main1(string[] args)
        {
            // Long 자료형을 Int 자료형으로 변환합니다.

            // 잘못된 예시

            /*long longNumber = 2147483647L + 21477483647L;
              int intNumber = longNumber;
              Console.WriteLine(intNumber);
            */

            // 옳은 예시

            long longNumber = 2147483647L + 2147483647L;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);

        }
    }
}
