using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/03
 * 이름 : 김태언
 * 내용 : 소수 만들기
 */
namespace Programers.Level_1
{
    internal class _1_10
    {
        static void Ma1in(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            Solution s1 = new Solution();
            Console.WriteLine(s1.solution(nums));
        }
        class Solution
        {
            public int solution(int[] nums)
            {
                // 주어진 숫자중 3개를 합한 값이 소수가 되는 경우의 수를 찾아 출력하시오.
                int answer = 0;
                // 중복된 값을 막기 위한 작업
                // 첫번째 숫자
                for (int i = 0; i < nums.Length - 2; i++)
                {
                    // 두번째 숫자
                    for (int j = i + 1; j < nums.Length - 1; j++)
                    {
                        // 세번째 숫자
                        for (int k = j + 1; k < nums.Length; k++)
                        {
                            // 더한 값
                            int x = nums[i] + nums[j] + nums[k];
                            // 소수인지 확인하기
                            int count = 0;
                            for (int z = 2; z <= x; z++)
                            {
                                if (x % z == 0)
                                {
                                    count++;
                                }
                            }
                            // 소수는 1을 제외하면 나눌 수 있는 숫자는 본인 숫자 밖에 없어야한다.
                            if (count == 1)
                            {
                                // 소수인지확인되면 ++
                                answer++;
                            }
                        }
                    }
                }
                // 리턴
                return answer;
            }
        }
    }
}
