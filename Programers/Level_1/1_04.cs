using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/02
 * 이름 : 김태언
 * 내용 : 내적
 */
namespace Programers.Level_1
{
    internal class _1_04
    {
        static void Ma1in(string[] args)
        {
            // 길이가 같은 두 1차원 정수 배열 a, b가 주어짐
            int[] a = { 1, 2, 3, 4};
            int[] b = {-3, -1, 0, 2};
            // a와 b의 내적을 return 받아야함
            Solution s1 = new Solution();

            Console.WriteLine(s1.solution(a, b));
        }
        public class Solution
        {
            public int solution(int[] a, int[] b)
            {
                int answer = 0; // 값을 저장할 변수
                for (int i = 0; i < a.Length; i++)
                {
                    answer += a[i] * b[i]; // 내적을 구하고 그 값을 변수에 저장한다.
                }
                // 리턴
                return answer;
            }
        }
    }
}
