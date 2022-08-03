using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/03
 * 이름 : 김태언
 * 내용 : [총정리 문제] 반복문 원주율 계산
 * 
 * 원주율 공식
 *  PI = 4{1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13 ... )
 *  - 항수를 늘릴수록 정확도가 높아진다.
 */
namespace Exam._08
{
    internal class _08_07
    {
        static void Ma1in(string[] args)
        {
            bool sign = false;
            double pi = 0;

            for (int i=1; i<=10000; i += 2)
            {
                if (sign == false)
                {
                    pi += 1.0 / i;
                    sign = true;
                }
                else
                {
                    pi -= 1.0 / i;
                    sign = false;
                }
                Console.WriteLine("i = {0}, PI = {1}", i, 4*pi);
            }
        }
    }
}
