using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/04
 * 이름 : 김태언
 * 내용 : [총정리 문제] 버블정렬
 */
namespace Exam._09
{
    internal class _09_04
    {
        static void Mai1n(string[] args)
        {
            int[] values = { 3, 5, 2, 7, 1 };
            PrintArray(values);

            for (int i=4; i>0; i--)
            {
                for (int j=0; j<i; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        int temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }
                }
                PrintArray(values);
            }
        }

        public static void PrintArray(int[] array)
        {
            foreach(var i in array)
            {
                Console.Write("{0, 5}", i);
            }
            Console.WriteLine();
        }
    }
}
