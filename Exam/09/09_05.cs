using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/04
 * 이름 : 김태언
 * 내용 : [총정리 문제] 재귀 메서드
 */
namespace Exam._09
{
    internal class _09_05
    {
        static void M1ain(string[] args)
        {
            int a = 10;
            int b = 30;
            int c = 20;

            Console.WriteLine("가장 큰 수는 {0} 입니다.", Larger(Larger(a, b), c));
        }

        public static int Larger(int a, int b)
        {
            return (a >= b) ? a : b;
        }
    }
}
