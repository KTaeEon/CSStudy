using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P268
    {
        class Test
        {
            public void Print()
            {
                Console.WriteLine("Print() 메서드가 호출되었습니다.");
            }
        }

        static void Main1(string[] args)
        {
            Test test = new Test(); // Test 타입의 test 객체 생성

            test.Print(); // print 메서드 호출
            test.Print();
            test.Print();
        }
    }
}
