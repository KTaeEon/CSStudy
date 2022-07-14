using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // thread 메서드를 사용하기 위한 코드

namespace Book.Ch04
{
    internal class P186
    {
        static void Mai1n(string[] args)
        {
            Console.WriteLine("메서드 호출 전");
            Console.SetCursorPosition(5,5);     // 커서 이동
            Console.WriteLine("메서드 호출 후");

            Console.WriteLine("첫 번째 출력");
            Thread.Sleep(1000);                // 1000은 1초
            Console.WriteLine("두 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("세 번째 출력");
        }
    }
}
