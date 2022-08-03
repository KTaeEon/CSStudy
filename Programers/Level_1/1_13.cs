using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/03
 * 이름 : 김태언
 * 내용 : 최소 직사각형
 */
namespace Programers.Level_1
{
    // 얼핏보면 힘들 수 있는 문제지만
    // 인덱스에 있는 " " 로 구분된 양 정수의 값중 가장 큰 값과 작은 값만 구분하면 쉬움
    internal class _1_13
    {
        static void Mai1n(string[] args)
        {
            int[,] sizes = { { 60, 50 }, { 30, 70 }, { 60, 30 }, { 80, 40 } };
            Solution s1 = new Solution();
            Console.WriteLine(s1.solution(sizes));
    }
        public class Solution
        {
            public int solution(int[,] sizes)
            {
                // 2차원 배열을 받아오기
                int answer = 0;
                // 2차원 배열의 인덱스를 분리시킬 List 2개 생성
                // 인덱스 중 가장 큰값
                List<int> max = new List<int>();
                // 인덱스중 가장 작은 값
                List<int> min = new List<int>();
                // 반복문을 통하여 구분
                for (int i = 0; i < sizes.Length / 2; i++)
                {
                    if (sizes[i, 0] <= sizes[i, 1])
                    {
                        max.Add(sizes[i, 1]);
                        min.Add(sizes[i, 0]);
                    }
                    else
                    {
                        max.Add(sizes[i, 0]);
                        min.Add(sizes[i, 1]);
                    }
                }
                // 리스트에 저장된 양 정수중 가장 큰 값만 출력하여 곱함 ( 넓이 구하기 )
                answer = (max.Max()) * (min.Max());
                // 리턴
                return answer;
            }
        }
    }
}
