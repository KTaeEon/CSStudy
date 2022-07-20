
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P290
    {
        static void Ma1in(string[] args)
        {
            // Math.PI = 20; 는 불가능함  Math.PI의 값은 상수(constant) 이기 때문 변수가 아님 !

            int r = 10;
            Console.WriteLine("원의 둘레: " + (2 * Math.PI * r));
            Console.WriteLine("원의 넓이: " + (Math.PI * r * r));
        }
    }
}
