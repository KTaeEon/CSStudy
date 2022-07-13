using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P114
    {
        static void Main(string[] args)
        {
            // 문자열로 변환 시 소수점 제거

            double number = 52.273103;
            Console.WriteLine(number.ToString("0.0"));
            Console.WriteLine(number.ToString("0.00"));
            Console.WriteLine(number.ToString("0.000"));
            Console.WriteLine(number.ToString("0.0000"));

            Console.WriteLine(52 + 273);
            Console.WriteLine("52"+ 273);
            Console.WriteLine(52 + "273");
            Console.WriteLine("52"+ "273");


        }
    }
}
