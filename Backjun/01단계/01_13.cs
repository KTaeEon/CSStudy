using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 김태언
 * 내용 : 백준 1단계 13번 문제 곱셈
 */
namespace Backjun._01단계
{
    internal class _01_13
    {
        static void Mai1n(string[] args)
        {
            string str = Console.ReadLine();
            string str1 = Console.ReadLine();
            char[] c = str1.ToCharArray();

            int a = int.Parse(str);
            int[] b = new int[c.Length];

            for (int i = 0; i < c.Length;i++)
            {
                b[i] = int.Parse(c[i].ToString());
            }

            Console.WriteLine(a*b[2]);
            Console.WriteLine(a*b[1]);
            Console.WriteLine(a*b[0]);
            Console.WriteLine((a * b[2]) + ((a * b[1])*10) + ((a * b[0])*100));
        }
    }
}
