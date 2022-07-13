using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P110_111
    {
        static void Main11(string[] args)
        {
            // string 자료형을 int 자료형으로 변환합니다.

            /*     실행되지 않는 코드  ( 잘못된 예시 )
            string numberString = "52273";
            int intNumber = (int)numberString;
            Console.WriteLine(intNumber);
            */

            // 변환의 옳은 예

            Console.WriteLine(int.Parse("52"));
            Console.WriteLine(long.Parse("273"));
            Console.WriteLine(float.Parse("52.273"));
            Console.WriteLine(double.Parse("103.32"));

            Console.WriteLine(int.Parse("52").GetType());
            Console.WriteLine(long.Parse("273").GetType());
            Console.WriteLine(float.Parse("52.273").GetType());
            Console.WriteLine(double.Parse("103.32").GetType());

            // Parse 의 메서드의 매개변수엔 변환이 가능한 문자열만 넣을 것 !

        }
    }
}
