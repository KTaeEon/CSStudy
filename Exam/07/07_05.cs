using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/02
 * 이름 : 김태언
 * 내용 : [총정리 문제] 문자열과 숫자의 변환
 */
namespace Exam._07
{
    internal class _07_05
    {
        static void Mai1n(string[] args)
        {
            int first = 10;
            int second = 20;
            bool result = false;

            result = (first == second);
            Console.WriteLine("{0} == {1} : {2}", first, second, result);

            result = (first < second);
            Console.WriteLine("{0} < {1} : {2}", first, second, result);

            result = (first >= second);
            Console.WriteLine("{0} >= {1} : {2}", first, second, result);

            result = (first != second);
            Console.WriteLine("{0} != {1} : {2}", first, second, result);

            result = (first == second) || (first > 5);
            Console.WriteLine("{0} || {1} : {2}", first == second, first > 5, result);

            result = (first == second) && (first > 5);
            Console.WriteLine("{0} == {1} : {2}", first == second, first > 5, result);

            result = true ^ false;
            Console.WriteLine("{0} == {1} : {2}", true, false, result);
        }
    }
}
