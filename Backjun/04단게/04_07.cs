using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._04단게
{
    internal class _04_07
    {
        static void Ma1in(string[] args)
        {
            int N = int.Parse(Console.ReadLine());             // 입력받을 케이스의 갯수

            for (int i = 0; i< N; i++)
            {
                string[] starr = Console.ReadLine().Split();   // 학생의 수  + 점수입력받기
                int[] input = Array.ConvertAll(starr[1..],int.Parse);
                double avg = 0;                                // 반 평균 점수
                double result = 0;                             // 출력값
                int num = 0;

                avg = input.Average();

                
                for (int k = 0; k < input.Length; k++)
                {
                    if (avg < input[k])           // Avg보다 높은 점수가 있는지 확인하기
                    {
                        num++;                   // 높다면 인풋(1명이 반에서 가지는 퍼센트율)을 정답에 추가
                    }
                }
                result = (double)num / (double)input.Length * 100;
                // 반에서 평균점수보다 높은 점수를 가진 사람의 비율 출력
                Console.WriteLine("{0:0.000}"+"%",result); 
            }
        }
    }
}
