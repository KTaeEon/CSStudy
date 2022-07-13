using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P145
    {
        static void Main1(string[] args)
        {

            // Contains 메서드를 조건식에 넣어
            // 자료형 안에 지정해둔 글자를 확인하고 참이라면 if 문구를 실행시킵니다. 
            Console.Write("입력 : ");
            string line = Console.ReadLine();

            if (line.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요...!");
            }
            else
                Console.WriteLine("^^");
        }

    }
}
