using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P165
    {
        static void Main1(string[] args)
        {

            // do while은 문장이 한번은 실행되야할때 쓰임

            string input;
            do
            {
                Console.Write("입력(exit을 입력하면 종료): ");
                input = Console.ReadLine();
            }
            while (input != "exit");
        }
    }
}
