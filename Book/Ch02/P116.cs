using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P116
    {
        static void Main1(string[] args)
        {

            // 문자열을 불로 변환할때 대소문자는 구분하지않음

            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("False"));
            Console.WriteLine(bool.Parse("false"));
        }
    }
}
