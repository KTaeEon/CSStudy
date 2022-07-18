using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P208
    {
        static void Ma1in(string[] args)
        {
            Random random = new Random();             // new 랜덤 변수 선언
            Console.WriteLine(random.Next(10, 100));  // 10 ~ 100까지 임의로 정해진 랜덤한 정수값 출력
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
        }
    }
}
