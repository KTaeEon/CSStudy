using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/04
 * 이름 : 김태언
 * 내용 : [총정리 문제] 피라미드 메서드
 */
namespace Exam._09
{
    internal class _09_07
    {
        static void M1ain(string[] args)
        {
            DrawPyramid(3);
            DrawPyramid(5);
            DrawPyramid(7);
        }

        public static void DrawPyramid(int n)
        {
            for (int i=1; i<=n; i++)
            {
                for (int j=i; j<n; j++)
                {
                    Console.Write(" ");
                }
                for(int k =1; k <=(i*2)-1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
