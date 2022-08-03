using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/03
 * 이름 : 김태언
 * 내용 : 나머지가 1이 되는 수 구하기
 */
namespace Programers.Level_1
{
    internal class _1_14
    {
        static void M1ain(string[] args)
        {
            int n = 10;
            Solution s1 = new Solution();
            int res = s1.solution(n);
            Console.WriteLine(res);
        }
        public class Solution
        {
            public int solution(int n)
            {
                // 정수 n 받아오기
                // 정답을 담을 변수 선언
                int answer = 0;
                // 반복문을 통해 2부터 n까지 나누어보기
                for (int x = 2; x < n; x++)
                {
                    // 나누어진 나머지가 1인 경우 answer에 값을 저장함
                    // 나누어지는 최소의 수만 알면 되기 떄문에 break;
                    if (n % x == 1)
                    {
                        answer = x;
                        break;
                    }
                }
                // 리턴
                return answer;
            }
        }
    }
}
