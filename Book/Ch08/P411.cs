﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class P411
    {
        class PointClass
        {
            public int x;
            public int y;

            public PointClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        struct PointStruct
        {
            public int x;
            public int y;

            public PointStruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main(string[] args)
        {
            // 클래스
            PointClass pointClassA = new PointClass(10, 20);
            PointClass pointClassB = pointClassA; // 참조 복사

            pointClassB.x = 100;
            pointClassB.y = 200;

            Console.WriteLine("pointClassA: " + pointClassA.x +","+pointClassA.y);
            Console.WriteLine("pointClassB: " + pointClassB.x +","+pointClassB.y);

            // 구조체
            PointStruct pointStructA = new PointStruct(10, 20);
            PointStruct pointStructB = pointStructA;  // 값 복사 

            pointStructB.x = 100;
            pointStructB.y = 200;

            Console.WriteLine("pointStructA: " + pointStructA.x + "," + pointStructA.y);
            Console.WriteLine("pointStructB: " + pointStructB.x + "," + pointStructB.y);
        }
    }
}
