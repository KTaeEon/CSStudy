﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/04
 * 이름 : 김태언
 * 내용 : [총정리 문제] 제네릭 메서드
 */
namespace Exam._09
{
    internal class _09_10
    {
        static void Mai1n(string[] args)
        {
            int[] a = { 1, 2, 3 };
            double[] d = { 0.1, 0.2, 0.3 };
            string[] s = { "apple", "banana", "cherry" };

            PrintArray<int>(a);
            PrintArray<double>(d);
            PrintArray<string>(s);
        }

        public static void PrintArray<T>(T[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write("{0,8}", item);
            }
            Console.WriteLine();
        }
    }
}
