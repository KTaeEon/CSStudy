using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P163
    {
        static void Main1(string[] args)
        {
            // while 반복문 이용
            int i = 0;
            int[] intArray = { 52, 273, 32, 65, 103 };

            // 반복을 수행합니다.
            while (i < intArray.Length)
            {
                // 출력합니다.
                Console.WriteLine(i + "번째 출력:" + intArray[i]);

                // 탈출을 위해 변수를 만듭니다.

                i++;

            }
        }
    }
}
