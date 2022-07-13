using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P102
    {
        static void Main1(string[] args)
        {
            var numberA = 100L;   //Long 자료형
            var numberB = 100.0;  //double 자료형
            var numberC = 100.0F; //float 자료형

            Console.WriteLine(123456 + 65432l); // 1이랑 l이랑 착각하니 L소문자 사용하지 않을 것

            Console.WriteLine(123456 + 65432L); // 맞게된 표기
        }
    }
}
