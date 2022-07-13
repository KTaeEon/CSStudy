using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/12 
 * 이름 : 김태언
 * 내용 : 조건문 S0witch 실습하기 교재 p127 
 */
namespace Ch03
{
    internal class _2_Switch문
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 입력 : ");
            string strnum = Console.ReadLine();
            

            int num = int.Parse(strnum);

            switch(num >= 75)
            {
                case true:
                    Console.WriteLine($"{num}는 성공 입니다.");
                    break;
                case false:
                    Console.WriteLine($"{num}는 실패 입니다.");
                    break;
            }



        }
    }
}
