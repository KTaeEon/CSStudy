using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P185
    {
        static void Main1(string[] args)
        {
            // 배열을 문자열로 변환합니다.
            // Join은 배열을 뭉쳐 문자열로 변환시켜주는 메서드
            string[] array = { "감자", "고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(",",array));

            Console.Clear();                  // 콘솔창을 지웁니다
            Console.SetCursorPosition(5,5);   // 콘솔의 특정 위치로 커서를 이동합니다
            Thread.Sleep(100);                // 특정시간만큼 스레드를 정지합니다.
        }
    }
}
