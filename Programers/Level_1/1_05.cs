using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/02
 * 이름 : 김태언
 * 내용 : K번째 수
 */
namespace Programers.Level_1
{
    internal class _1_05
    {
        static void Ma1in(string[] args)
        {
            // 배열 array의 i번째 숫자부터 j번째 숫자까지 자르고 정렬했을 때, k번째의 있는 수 구하기
            int[] array = { 1, 5, 2, 6, 3, 7, 4 };                           // 배열 array
            int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };     // 2차원 배열 { i, j, k } 
            Solution s1 = new Solution();
            int[] x = s1.solution(array, commands);

            // 출력하기
            foreach (var i in x)
            {
                Console.Write(i+" ");
            }
             
        }
        public class Solution
        {
            public int[] solution(int[] array, int[,] commands)
            {
                // 리턴해야할 배열 구하기 
                int[] answer = new int[commands.Length / 3];
                // commands 매개변수 안에 있는 i, j, k를 구하고 i번째부터 j번째까지 자르고 정렬 후 k번째의 수 구하는 작업
                for (int x = 0; x < (commands.Length / 3); x++)
                {
                    // x 는 commands의 2차원 배열이 길이 ( 총 실행될 반복횟수 )

                    int i = commands[x, 0] - 1; // i
                    int j = commands[x, 1];     // j
                    int k = commands[x, 2];     // k
                    List<int> list = new List<int>(); // 자른 배열들 넣을 곳
                    for (; i < j; i++)
                    {
                        list.Add(array[i]);  // 자른 배열들을 넣는 작업
                    }
                    list.Sort(); // 정렬
                    answer[x] = list[k - 1]; // k번째의 수 구하고 정답 배열에 넣기
                }
                // 리턴
                return answer;
            }
        }
    }
}
