using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P229
    {
        class MyMath // 클래스 생성
        {
            // 클래스 변수 생성 (static)
            public static double PI = 3.141592;
        }

        static void Main(string[] args)
        {
            // 클래스 변수 사용
            Console.WriteLine(MyMath.PI);
        }
    }
}
