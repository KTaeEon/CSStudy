using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    struct Point
    {
        public int x;
        public int y;

        // 구조체 생성자 ( 구조체는 매개변수가 없는 생성자는 선언 불가능)
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    internal class P406
    {
        static void Mai1n(string[] args)
        {
            Point point = new Point();

            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
        }
    }
}
