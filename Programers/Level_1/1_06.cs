using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * 날짜 : 2022/08/02
 * 이름 : 김태언
 * 내용 : 나머지가 1이 되는 수 구하기
 */
namespace Programers.Level_1
{
    internal class _1_06
    {
        static void Ma1in(string[] args)
        {
            // 매개변수 입력받기
            int n = int.Parse(Console.ReadLine());
            Solution s1 = new Solution();
            Console.WriteLine(s1.solution(n));
        }
        public class Solution
        {
            public int solution(int n)
            {
                // 값을 저장할 변수 선언
                int answer = 0;

                // 나머지가 1이 될때까지 오름차순으로 반복
                for (int x = 1; x < n; x++)
                {
                    if (n % x == 1)
                    {
                        answer = x; // 나머지가 1이 되는 가장 최소값
                        break; // 나머지가 1이 될 시 바로 종료
                    }
                }
                //리턴
                return answer;
            }
        }
    }
}
