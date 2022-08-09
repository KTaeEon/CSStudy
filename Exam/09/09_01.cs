using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/04
 * 이름 : 김태언
 * 내용 : [총정리 문제] 배열과 메서드
 */
namespace Exam._09
{
    internal class _09_01
    {
        static void Ma1in(string[] args)
        {
            int[] arr1 = { 5, 25, 75, 35, 15 };
            PrintArray(arr1);

            int[] arr2 = (int[])arr1.Clone();
            PrintArray(arr2);

            int[] arr3 = new int[10];
            arr1.CopyTo(arr3, 3);
            PrintArray(arr3);

            Array.Sort(arr1);
            PrintArray(arr1);

            Array.Reverse(arr1);
            PrintArray(arr1);
        }
        public static void PrintArray(int[] arr)
        {
            foreach(var i in arr)
            {
                Console.Write("  {0, 2}", i);
            }
            Console.WriteLine();
        }
    }
}
