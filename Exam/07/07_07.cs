using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/02
 * 이름 : 김태언
 * 내용 : [총정리 문제] 문자열
 */
namespace Exam._07
{
    internal class _07_07
    {
        static void Ma1in(string[] args)
        {
            Console.Write("더하고자 하는 숫자들을 입력 : ");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int sum = 0;
            string[] v = s.Split();

            foreach(string i in v)
            {
                sum += int.Parse(i);
            }
            Console.WriteLine("결과 : {0}",sum);
        }
    }
}
