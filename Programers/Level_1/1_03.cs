using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/02
 * 이름 : 김태언
 * 내용 : 음양 더하기
 */
namespace Programers.Level_1
{
    internal class _1_03
    {
        static void Ma1in(string[] args)
        {
            // absolutes의 부호를 차례대로 담은 signs값 존재
            int[] absolutes = { 4, 7, 12 };
            bool[] signs = { true, false, true };
            Solution s1 = new Solution();
            Console.WriteLine(s1.solution(absolutes, signs));
        }
        public class Solution
        {
            // signs 값이 true 일 경우 정수 , false 일 경우 음수로 변환하고 그 값을 다 더해야함

            public int solution(int[] absolutes, bool[] signs)
            {
                int answer = 0; // 더한 값 저장할 변수

                for (int i = 0; i < absolutes.Length; i++)
                {
                    // 해당 absolutes의 signs이 false 인지 true인지 확인하고 변환하는 작업
                    if (signs[i] == false)
                    {
                        absolutes[i] = -absolutes[i];
                    }
                    // 총 합을 구하는 작업
                    answer += absolutes[i];
                }
                // 리턴
                return answer;
            }
        }
    }
}
