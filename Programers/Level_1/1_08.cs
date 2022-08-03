using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/03
 * 이름 : 김태언
 * 내용 : 신고 결과 받기
 */
namespace Programers.Level_1
{
    internal class _1_08
    {
        static void Ma1in(string[] args)
        {
            string[] id_list = { "muzi", "frodo", "apeach", "neo" };
            string[] report = { "muzi frodo", "apeach frodo", "frodo neo", "muzi neo", "apeach muzi" };
            int k = 2;
            Solution s1 = new Solution();
            int[] n = s1.solution(id_list, report, k); // 각 유저들이 얼마나 메일을 받을 지 결과 받기
            foreach(var i in n) // 출력
            {
                Console.Write(i + " ");
            }
            
    }
        public class Solution
        {
            public int[] solution(string[] id_list, string[] report, int k)
            {
                int[] answer = new int[id_list.Length];
                List<string> user = new List<string>();
                List<string> repo = new List<string>();
                List<string> log = new List<string>();
                for (int i = 0; i < report.Length; i++)
                {
                    string[] x = report[i].Split();
                    user.Add(x[0]);
                    repo.Add(x[1]);
                }
                for (int i = 0; i < id_list.Length; i++)
                {
                    int count = 0;
                    for (int j = 0; j < repo.Count; j++)
                    {
                        if (id_list[i] == repo[j] && log.Contains(user[j]) == false)
                        {
                            log.Add(user[j]);
                            count++;
                        }
                    }
                    if (count >= k)
                    {
                        for (int z = 0; z < id_list.Length; z++)
                        {
                            if (log.Contains(id_list[z]))
                            {
                                answer[z]++;
                            }
                        }
                    }
                    log.Clear();
                }
                return answer;
            }
        }
    }
}
