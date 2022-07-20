using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P291
    {
        // 상수를 사용하는 이유는 그 값을 고정하기 위함
        // 변경이 불가능
        class MyMath
        {
            public const double PI = 3.141592;
        }

        // 일반적인 메서드에서도 사용이 가능하나 하나의 메서드에 상수를 쓰는 경우는 적음
        static void Mai1n(string[] args)
        {
            const int value = 10;

            Console.WriteLine(value);
        }
    }
}
