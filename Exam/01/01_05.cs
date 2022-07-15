using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 김태언
 * 내용 : 문자열 처리 연습문제
 */
namespace Exam._01_05
{
    internal class _01_05
    {
        static void Mai1n(string[] args)
        {
            string strScore = "60,72,82,86,92";
            string[] scores = strScore.Split(",");

            int total = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                total += int.Parse(scores[i]);
            }

            Console.WriteLine("총점 : " + total);
        }
    }
}
