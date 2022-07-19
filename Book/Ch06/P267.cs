using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P267
    {
        class Test
        {
            // 두개의 매개변수를 갖는 메서드

            public int Multi(int x, int y) // 매개변수값을 넣어줘야 실행된다.
            {
                return x * y; // 반환값
            }
        }

        static void Ma1in(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Multi(52, 273)) ;
            Console.WriteLine(test.Multi(103, 32)) ;
        }
    }
}
