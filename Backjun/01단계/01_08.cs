﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 김태언
 * 내용 : 백준 1단계 8번 문제 A/B
 */
namespace Backjun._01단계
{
    internal class _01_08
    {
        static void Ma1in(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            double a = double.Parse(str[0]);
            double b = double.Parse(str[1]);

            Console.WriteLine(a / b);

        }
    }
}
