using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    class Program
    {
        class Math { } // Math 클래스 선언

        static void Ma1in(string[] args)
        {
            // Console.WriteLine(Math.Abs(-10));  <- 불가능한 출력값
            // Math 라는 클래스를 선언함에 따라 C#에서 지원하는 Math 기본 클래스를 사용 못하게 됨
        }
    }
}
