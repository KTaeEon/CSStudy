using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 김태언
 * 내용 : 다이아몬드 출력 연습문제
 */
namespace Exam._01_09
{
    internal class _01_09
    {
        static void M1ain(string[] args)
        {
            int count = 0;

            for (int i = 1; i <= 9; i++)
            {
                if (i <= 5)
                {
                    count++;
                }
                else
                {
                    count--;
                }

                
                for (int j = 0; j < (5 - count); j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= (2 * count - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
