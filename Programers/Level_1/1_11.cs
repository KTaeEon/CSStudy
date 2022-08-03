using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/03
 * 이름 : 김태언
 * 내용 : 예산
 */
namespace Programers.Level_1
{
    internal class _1_11
    {
        static void Main(string[] args)
        {
            int[] d = { 1, 3, 2, 5, 4 };
            int budget = 9;
            Solution s1 = new Solution();
            Console.WriteLine(s1.solution(d, budget));

        }
        public class Solution
        {
            public int solution(int[] d, int budget)
            {
                // 규칙적이지 않은 int 배열과 총값을 넘으면 안되는 budget이 주어진다.
                // int 배열이 최대한 많이 사용되어야하며 budget을 넘지 말아야한다.
                int answer = 0;
                List<int> x = new List<int>();
                // List 에 불규칙적인 int 배열 넣기
                foreach (int i in d)
                {
                    x.Add(i);
                }
                // 정렬
                x.Sort();
                // 더한 값을 저장하기
                int res = 0;
                // 반복문을 통해 list를 작은 수 부터 더해준다.
                for (int i = 0; i < x.Count; i++)
                {
                    res += x[i];
                    // 만약 더한 값이 budget보다 높을 시 바로 멈춘다.
                    if (res > budget)
                    {
                        break;
                    }
                    // 더한 값이 안높을 시 answer 를 ++ 해준다.
                    answer++;
                }
                // 리턴
                return answer;
            }
        }
    }
}
