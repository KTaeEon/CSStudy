using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P286
    {
        class Sample
        {
            // 클래스 변수 (정적 변수)
            public static int value;

            // 정적 생성자
            static Sample()
            {
                value = 10;
                Console.WriteLine("정적 생성자 호출");
            }
        }
        static void Mai1n(string[] args)
        {
            Console.WriteLine("첫 번째 위치");
            Console.WriteLine(Sample.value);  // 정적 생성자는  해당 클래스 관련된 요소를 처음 사용하는 시점에서 자동적으로 호출됩니다. ( 별도 호출 X )
            Console.WriteLine("두 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("세 번째 위치");
        }
    }
}
