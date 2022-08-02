using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/02
 * 이름 : 김태언
 * 내용 : 숫자 문자열과 영단어
 */
namespace Programers.Level_1
{
    internal class _1_02
    {
        public class Solution
        {
            static void Ma1in(string[] args)
            {
                string s = "one2341threeeight90zero"; // 영어와 숫자가 합쳐진 문자열
                Solution s1 = new Solution();
                Console.WriteLine(s1.solution(s));
            }
            public int solution(string s)
            {
                char[] arr = s.ToCharArray();           // 입력받은 매개변수를 char배열로 변환
                StringBuilder sb = new StringBuilder(); // 스트링빌더 인스턴스 생성
                int answer = 0;                         // 정답을 입력받을 변수 생성

                for (int i = 0; i < arr.Length; i++)
                {
                    // 문자열중 영어의 시작점을 찾는 작업 
                    // 숫자끼리 중복되는 첫 단어가 있을시 한번 더 구분
                    // 문자의 수 만큼 i를 더하여 첫 단어만으로 빠른 서치 및 오류 방지
                    if (arr[i] == 'z')
                    {
                        sb.Append("0");
                        i += 3;
                        continue;

                    }
                    else if (arr[i] == 'o')
                    {
                        sb.Append("1");
                        i += 2;
                        continue;

                    }
                    else if (arr[i] == 't')
                    {
                        if (arr[i + 1] == 'w')
                        {
                            sb.Append("2");
                            i += 2;
                            continue;

                        }
                        else
                        {
                            sb.Append("3");
                            i += 4;
                            continue;

                        }
                    }
                    else if (arr[i] == 'f')
                    {
                        if (arr[i + 1] == 'o')
                        {
                            sb.Append("4");
                            i += 3;
                            continue;

                        }
                        else
                        {
                            sb.Append("5");
                            i += 3;
                            continue;

                        }
                    }
                    else if (arr[i] == 's')
                    {
                        if (arr[i + 1] == 'i')
                        {
                            sb.Append("6");
                            i += 2;
                            continue;

                        }
                        else
                        {
                            sb.Append("7");
                            i += 4;
                            continue;

                        }
                    }
                    else if (arr[i] == 'e')
                    {
                        sb.Append("8");
                        i += 4;
                        continue;

                    }
                    else if (arr[i] == 'n')
                    {
                        sb.Append("9");
                        i += 3;
                        continue;
                    }
                    // 단어가 아니면 무조건 숫자이니 스트링빌더에 Append 시킴
                    sb.Append(arr[i].ToString());
                }
                // 숫자로 다 변환한 스트링빌더 스트링으로 만든 후 int.parse 하여 int값으로 변환
                answer = int.Parse(sb.ToString());
                // 리턴
                return answer;
            }
        }
    }
}
