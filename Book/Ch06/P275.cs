using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P275
    {
        class MyMath
        {
            // 오버로딩 : 메서드가 같아도 받을 수 있는 매개변수가 다를때 일어난다.
            public static int Abs(int input)
            {
                if (input < 0)
                {
                    return -input;
                }
                else
                {
                    return input;
                }
            }

            public static double Abs(double input)
            {
                if (input < 0)
                {
                    return -input;
                }
                else
                {
                    return input;
                }
            }

            public static long Abs(long input)
            {
                if (input < 0)
                {
                    return -input;
                }
                else
                {
                    return input;
                }
            }

            static void Ma1in(string[] args)
            {
                // int
                Console.WriteLine(MyMath.Abs(52));
                Console.WriteLine(MyMath.Abs(-273));

                // double
                Console.WriteLine(MyMath.Abs(52.273));
                Console.WriteLine(MyMath.Abs(-32.103));

                // long
                Console.WriteLine(MyMath.Abs(21474836470));
                Console.WriteLine(MyMath.Abs(-21474836470));
            }
        }
    }
}
