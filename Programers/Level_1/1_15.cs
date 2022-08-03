using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/03
 * 이름 : 김태언
 * 내용 : 부족한 금액 계산하기
 */
namespace Programers.Level_1
{
    internal class _1_15
    {
        static void Ma1in(string[] args)
        {
            int price = 3;
            int money = 20;
            int count = 4;
            Solution s1 = new Solution();
            Console.WriteLine(s1.solution(price, money, count));
        }
        class Solution
        {
            public long solution(int price, int money, int count)
            {
                // 한번씩 탈수록 N배로 증가함
                // 문제의 제한사항에선 값이 엄청 컸었기 때문에 long 자료형 사용
                long pay = 0;
                // count만큼 타게되면 내야할 돈을 계산
                for (int i = 1; i <= count; i++)
                {
                    pay += (price * i);
                }
                // 내야할 돈이 가진 돈 보다 같거나 적다면 0 return
                if (pay <= money)
                {
                    return 0;
                }
                // 아닌 경우엔 내야할 돈 - 가진 돈 을 하면 부족한 돈을 알 수 있음
                else
                {
                    long answer = pay - money;
                    return answer;
                }
            }
        }
    }
}
