using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P357
    {
        // 클래스 변수
        public static int number = 10;

        static void M1ain(string[] args)
        {
            // 메서드 변수

            int number = 20;
            Console.WriteLine(number);  // 메서드 내부에서 출력되기에 메서드 변수가 클래스 변수를 섀도잉함
        }
    }
}
