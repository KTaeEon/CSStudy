using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P302
    {
        static void Change(int input)
        {
            input = 20;
        }

        static void Ma1in(string[] args)
        {
            // a 변수 선언
            int a = 10;
            // 메서드 Change에 매개변수 a를 대입
            Change(a);
            // a는 결과적으로 변하지 않았기 때문에 10 출력
            Console.WriteLine(a);
        }
    }
}
