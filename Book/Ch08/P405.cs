using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class P405
    {
        // new 키워드를 사용하지 안고 고조체 인스턴스 생성
        struct Point
        {
            public int x;
            public int y;
        }

        static void M1ain(string[] args)
        {
            Point point;
            point.x = 10;
            point.y = 10;

            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
        }
    }
}
