using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 김태언
 * 내용 : 백준 1단계 12번 문제 나머지
 */
namespace Backjun._01단계
{
    internal class _01_12
    {
        static void M1ain(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            int c = int.Parse(str[2]);

            Console.WriteLine((a+b)%c);
            Console.WriteLine(((a%c)+(b%c))%c);
            Console.WriteLine((a*b)%c);
            Console.WriteLine(((a%c)*(b%c))%c);


        }
    }
}
