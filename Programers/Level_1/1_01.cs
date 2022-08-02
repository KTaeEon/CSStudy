using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * 날짜 : 2022/08/02
 * 이름 : 김태언
 * 내용 : 없는 숫자 더하기
 */
namespace Programers.Level_1
{
    internal class _1_01
    {
        public class Solution
        {
            public int solution(int[] numbers)
            {
                int answer = -1; // 기본값
                int x = 0;    // 매개변수의 총합을 담을 변수
                int n = 45;   // 0 ~ 9 까지 총합
                foreach (int i in numbers)
                {
                    x += i; // 매개변수 배열의 총 합을 구하기
                } 
                if (x != n) // 서로 값이 다른 경우 총합에서 매개변수 총합을 뺍니다.
                {
                    answer = n - x;
                }
                return answer; // 리턴
            }
        }
        static void Ma1in(string[] args)
        {
            // 정수 0 ~ 9 까지 랜덤한 숫자의 배열중 없는 숫자를 더한 값을 출력하기
            int[] numbers = { 1, 2, 4, 5, 6, 8, 0 };
            Solution sol = new Solution();

            // 결과 값 받기
            Console.WriteLine(sol.solution(numbers));
        }
    }
}
