using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P307
    {
        // 재귀메서드란 : 메서드 내부에서 자신의 메서드를 호출하는 경우를 말한다.
        class Fibonacci
        {
            public long Get(int i)
            {
                if (i < 0) { return 0; }
                if (i == 1) { return 1; }
                return Get(i - 2) + Get(i - 1); // 재귀 메서드 사용 예시
            }
        }
        static void Mai1n(string[] args)
        {
            Fibonacci fibo = new Fibonacci();
            Console.WriteLine(fibo.Get(1));
            Console.WriteLine(fibo.Get(2));
            Console.WriteLine(fibo.Get(3));
            Console.WriteLine(fibo.Get(4));
            Console.WriteLine(fibo.Get(5));
        }
    }
}
