﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 김태언
 * 내용 : 조건문, 반복문 연습문제
 */
namespace Exam._01_07
{
    internal class _01_07
    {
        static void Ma1in(string[] args)
        {
            int total = 0;

            for (int k = 1; k <= 10; k++)
            {
                if (k % 3 == 0 || k % 2 == 0)
                {
                    total += k;
                }
            }
            Console.WriteLine("1 ~ 10까지 2와 3배수의 정수의 합 : "+ total);
        }
    }
}
