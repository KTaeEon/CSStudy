using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P303
    {
        static void M1ain(string[] args)
        {
            // 이는 결과적으로 a는 영향을 받지 않았기 때문에 10이 출력
            int a = 10;
            int input = a;
            input = 20;
            Console.WriteLine(a);
        }
    }
}
