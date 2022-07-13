using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P161
    {
        static void Main1(string[] args)
        {
            // 원하는 크기의 배열 생성방법

            int[] array = new int[100];

            // 특정한 크기의 배열 생성

            int[] intArray = new int[100];

            // 요소의 길이를 출력합니다.
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[99]);

            // 배열을 생성하기만 해서 결과는 0 으로만 뜸
        }
    }
}
