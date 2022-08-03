using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/03
 * 이름 : 김태언
 * 내용 : 로또의 최고 순위와 최저 순위
 */
namespace Programers.Level_1
{
    internal class _1_09
    {
        static void Ma1in(string[] args)
        {
            // 나의 로또 0 은 알 수 없는 번호(랜덤)
            int[] lottos = { 44, 1, 0, 0, 31, 25 };
            // 정답 로또 번호
            int[] win_nums = { 31, 10, 45, 1, 6, 19 };
            Solution s1 = new Solution();
            // 로또 당첨 최고 순위와 최저 순위 받기
            int[] result = s1.solution(lottos, win_nums);
            // 출력
            foreach (var i in result)
            {
                Console.Write(i + " ");
            }

        }
        public class Solution
        {
            public int[] solution(int[] lottos, int[] win_nums)
            {
                // 최고순위와 최저순위를 받기 위한 배열 생성
                int[] answer = new int[2];
                // List에 나의 로또 번호를 가져온다
                List<int> list = new List<int>();
                // 나의 로또 번호에서 0의 갯수를 확인하는 변수
                int count = 0;
                foreach (int i in lottos)
                {
                    // 로또 번호가 0일때 count가 ++ 된다.
                    if (i == 0)
                    {
                        count++;
                    }
                    // 로또 정답 번호중 0은 없으므로 따로 제거할 필요가 없음
                    list.Add(i);
                }
                // 로또 번호 확인하기
                for (int i = 0; i < 6; i++)
                {
                    // list의 Contains 메서드를 통해 정답번호가 있는지 확인
                    if (list.Contains(win_nums[i]))
                    {
                        // 있다면 answer을 ++ 한다.
                        answer[1]++;
                    }
                }
                // 방금 구한 로또 정답갯수는 최저순위 ( 0이 모두 틀렸을때 ) 와 같기 때문에 그대로
                // 최고순위는 이전에 count를 통하여 0의 갯수를 확인해
                // 주었으므로 그 값을 answer[0]배열에 더해준다.
                answer[0] = answer[1] + count;
                // answer 의 갯수에 따른 순위를 구분한다.
                for (int o = 0; o < 2; o++)
                {
                    if (answer[o] == 6)
                    {
                        answer[o] = 1;
                    }
                    else if (answer[o] == 5)
                    {
                        answer[o] = 2;
                    }
                    else if (answer[o] == 4)
                    {
                        answer[o] = 3;
                    }
                    else if (answer[o] == 3)
                    {
                        answer[o] = 4;
                    }
                    else if (answer[o] == 2)
                    {
                        answer[o] = 5;
                    }
                    else
                    {
                        answer[o] = 6;
                    }
                }
                // 리턴
                return answer;
            }
        }
    }
}
