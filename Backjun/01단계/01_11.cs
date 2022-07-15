using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 김태언
 * 내용 : 백준 1단계 5번 문제 1998년생인 내가 태국에서는 2541년생?!
 */
namespace Backjun._01단계
{
    internal class _01_11
    {
        static void Main1(string[] args)
        {
            string str = Console.ReadLine();
            int a = int.Parse(str);
            int z = 0;

            z = a - 543;
            Console.WriteLine(z);

        }
    }
}
