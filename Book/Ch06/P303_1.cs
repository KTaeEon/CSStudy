using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P303_1
    {
        class Test
        {
            public int value = 10;
        }

        static void Change(Test input)
        {
            input.value = 20; // test의 value값 10을 여기서 20으로 변경
        }

        static void Ma1in(string[] args)
        {
            Test test = new Test();
            test.value = 10;
            Change(test); // test.value의 값이 20으로 변경됨

            Console.WriteLine(test.value);
        }
    }
}
