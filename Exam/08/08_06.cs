﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/03
 * 이름 : 김태언
 * 내용 : [총정리 문제] 1000까지 소수 출력하기
 */
namespace Exam._08
{
    internal class _08_06
    {
        static void Ma1in(string[] args)
        {
            int index;
            int primes = 0;

            for(int i = 2; i < 1000; i++)
            {
                for(index = 2; index<i; index++)
                {
                    if (i % index == 0)
                    {
                        break;
                    }
                }

                if (index == i)
                {
                    primes++;
                    Console.Write("{0,5}{1}", i, primes % 15 == 0 ? "\n" : "");
                }
            }
            Console.WriteLine("\n2부터 1000사이의 소수의 개수 : {0}개", primes);
        }
    }
}
