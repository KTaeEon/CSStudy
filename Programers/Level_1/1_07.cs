using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/03
 * 이름 : 김태언
 * 내용 : 약수의 개수와 덧셈뺄셈
 */
namespace Programers.Level_1
{
    internal class _1_07
    {
        static void Mai1n(string[] args)
        {
            int left = 43;   // 최소값
            int right = 55;  // 최대값
            Solution s1 = new Solution();
            Console.WriteLine(s1.solution(left, right));
        }
        // 최소값부터 최대값까지의 수에 대한 약수를 모두 구하고
        // 해당 숫자에 대한 약수의 갯수가 짝수면 + 홀수면 - 를 한다.
        public class Solution
        {
            public int solution(int left, int right)
            {
                int answer = 0;

                for (int i = left; i <= right; i++)
                {
                    int result = 0;

                    for (int j = 1; j <= i; j++)
                    {
                        if ((i % j) == 0)
                        {
                            result++;
                        }
                    }
                    if ((result % 2) == 0)
                    {
                        answer += i;
                    }
                    else
                    {
                        answer = answer - i;
                    }
                }
                return answer;
            }
        }
    }
}
