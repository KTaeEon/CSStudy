using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P308
    {
        // 피보나치같은 수열을 구하고자 인스턴스를 계속해서 만드는 것 말고도 static(정적 메서드)로 변환시켜서 사용가능
            class Fibonacci
            {
                public static long Get(int i) // 스태틱 선언
                {
                    if (i < 0) { return 0; }
                    if (i == 1) { return 1; }
                    return Get(i - 2) + Get(i - 1); // 재귀 메서드 사용 예시
                }
            }

            static void M1ain(string[] args)
            {
                Console.WriteLine(Fibonacci.Get(1));
                Console.WriteLine(Fibonacci.Get(2));
                Console.WriteLine(Fibonacci.Get(3));
                Console.WriteLine(Fibonacci.Get(4));
                Console.WriteLine(Fibonacci.Get(5));

            // 결과 값은 앞과 동일
            }
    }
}

