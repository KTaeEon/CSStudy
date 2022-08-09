using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/04
 * 이름 : 김태언
 * 내용 : [총정리 문제] 소수 판별 메서드
 */
namespace Exam._09
{
    internal class _09_06
    {
        static void Ma1in(string[] args)
        {
            int count = 0;

            for (int i = 2; i <= 100; i++)
            {
                if(IsPrime(i))
                {
                    Console.Write("{0} ", i);
                    count++;
                }
            }
            Console.WriteLine("\n2~100까지 소수는 모두 {0}개 입니다.", count);
        }

        public static bool IsPrime(int x)
        {
            for (int i = 2; i < x; i++)
            {
                if ( x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
