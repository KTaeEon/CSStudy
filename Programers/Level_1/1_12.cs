using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/03
 * 이름 : 김태언
 * 내용 : 두 개 뽑아서 더하기
 */
namespace Programers.Level_1
{
    internal class _1_12
    {
        static void Ma1in(string[] args)
        {
            // 정수 배열에 서로 다른 인덱스인 두 수를 뽑아 더해서 만들 수 있는 모든 수를 출력하시오.
            int[] numbers = { 2, 1, 3, 4, 1 };
            Solution s1 = new Solution();
            int[] res = s1.solution(numbers);
            foreach(int n in res)
            {
                Console.Write(n + " ");
            }
        }

        public class Solution
        {
            public int[] solution(int[] numbers)
            {
                // List를 만들어서 더한 값 저장하기
                List<int> list = new List<int>();
                // 반복문을 통하여 numbers의 서로 다른 인덱스 번호를 더하기
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        int x = numbers[i] + numbers[j];
                        list.Add(x);
                    }
                }
                // list의 Distinct 메서드를 통하여 중복값 제거
                list = list.Distinct().ToList();
                // 정렬
                list.Sort();
                int count = 0;
                int[] answer = new int[list.Count];
                // 배열로 리턴해야하기 때문에 다시 배열로 변환
                foreach (int i in list)
                {
                    answer[count] = i;
                    count++;
                }
                // 리턴
                return answer;
            }
        }
    }
}
