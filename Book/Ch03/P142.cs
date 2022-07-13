using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P142
    {
        static void Main1(string[] args)
        {
            // 참과 거짓 위치에 불 자료형 사용
            int number = 3;
            
            Console.WriteLine(number % 2 == 0 ? true : false);


            // 참과 거짓 위치에 문자열 자료형 사용
            Console.WriteLine(number % 2 == 0 ? "짝수" : "홀수");

            // 삼항 연산자는 코드가 복잡해보일 수 있으므로 한 줄로 표시할 수 있을때만 사용할 것
            


        }

    }
}
