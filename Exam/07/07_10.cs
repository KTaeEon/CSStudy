﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/02
 * 이름 : 김태언
 * 내용 : [총정리 문제] ref
 * 
 * ref
 *  - ref 키워드는 메서드의 매개변수의 인자값이 참조로 전달할때 사용
 *  - ref에 의한 값 전달은 매개변수가 메서드에 넘겨진 원본 변수를 직접 참조
 */
namespace Exam._07
{
    internal class _07_10
    {
        static void Ma1in(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine("값 복사");
            Swap(x, y);
            Console.WriteLine($"x : {x}, y : {y}");

            Console.WriteLine("참조 복사");
            Swap(ref x, ref y);
            Console.WriteLine($"x : {x}, y : {y}");
            
        }

        public static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
    }
}
