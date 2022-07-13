using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P159
    {
        static void Main1(string[] args)
        {
            // 배열 생성하고 요소에 접근하기

            // 배열을 생성합니다
            int[] intArray = { 52, 273, 32, 65, 103 };

            // 배열의 요소를 변경합니다
            intArray[0] = 0;

            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);

            // 배열 Length의 속성 자료형의 길이 측정가능
            Console.WriteLine(intArray.Length);
        }
    }
}
