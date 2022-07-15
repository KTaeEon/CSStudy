using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._03단계
{
    internal class _03_04
    {
        static void Mai1n(string[] args)
        {
            // 스트링 빌더  answer 선언

            StringBuilder answer = new StringBuilder();
            int t = int.Parse(Console.ReadLine());

            // 계산을 위한 int 배열 생성
            int[] a = new int[t];
            int[] b = new int[t];

            for (int i = 0; i < t; i++)
            {
                // 숫자를 입력받고 Split으로 공백을 기준으로 나눈다음
                // string 문자열을 각각 int로 변환

                string[] str1 = Console.ReadLine().Split();
                a[i] = int.Parse(str1[0]);
                b[i] = int.Parse(str1[1]);

                // int로 연산식을 진행후 다시 문자열로 변환

                answer.Append((a[i] + b[i])+"\n");
            }
            Console.WriteLine(answer.ToString());
            // 출력
        }
    }
}
