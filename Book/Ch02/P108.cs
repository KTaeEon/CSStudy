using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P108
    {
        static void Main1(string[] args)
        {
            // long 자료형을 int 자료형으로 변환합니다.
            long longNumber = 52273;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);

            // 위에 같이 데이터가 작으면 데이터 손실 미발생

            long longN = 2147483647L + 2147483647L;
            int longToInt = (int)longN;
            Console.WriteLine(longToInt);

            // int 가 long의 데이터를 다 못담아서 데이터 손실 발생

            double doubleNumber = 52.27310332;
            int doubleToInt = (int)doubleNumber;
            Console.WriteLine(doubleToInt);

            // 실수에서 정수로 변환되면서 소수점이 사라짐 ( 데이터 손실 )
        }
    }
}
