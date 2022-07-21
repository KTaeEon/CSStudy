using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._06단계
{
    internal class _06_03
    {
        static void Ma1in(string[] args)
        {
            // 문자열 입력받기
            string str = Console.ReadLine(); 

            // 비교하기 위한 Char 배열
            char[] arr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            // 입력받은 문자열을 Char 배열로 변환
            char[] arr2 = str.ToCharArray();

            // 추출한 값을 저장하기 위해 스트링빌더를 사용
            StringBuilder sb = new StringBuilder();

            // 비교하기 위한 Char 배열을 for문으로 확인한다. 
            for (int i = 0; i < arr.Length; i++)
            {
                int a = -1;    // stringbulider 에 추가할 값

                for (int j = 0; j < str.Length; j++)  // Char배열로 변환한 값을 for문으로 다 확인한다.
                {
                    if (arr[i] == arr2[j]) // 배열값이 같다면 j(입력받은 값의 배열순서)로 변경한다.
                    {
                        a = j;
                        break;   // 가장 먼저
                    }

                }
                sb.Append(a + " ");
            }
            Console.WriteLine(sb);
        }
    }
}
