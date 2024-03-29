﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P309
    {
        class Fibonacci
        {
            private static Dictionary<int, long> memo = new Dictionary<int, long>();
            public static long Get(int i)
            {

                // 기본 값
                if ( i < 0 ) { return 0; }
                if ( i == 1 ) { return 1; }

                // 이미 계산했던 값인지 확인합니다.
                if (memo.ContainsKey(i))
                {
                    return memo[i];
                }
                else
                {
                    // 계산하지 않았다면 계산합니다
                    long value = Get(i - 2) + Get(i - 1);
                    memo[i] = value;
                    return value;
                }
            }
        }

        class Program
        {
            static void M1ain(string[] args)
            {
                Console.WriteLine(Fibonacci.Get(40));
                Console.WriteLine(Fibonacci.Get(100));
            }
        }
    }
}
