using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class P408
    {
        struct Point
        {
            public int x;
            public int y;
            public string testA;
            public string testB = "init";

            public Point(int x, int y) // 오버로딩중인 생성자
            {
                // 생성자는 반드시 모든 멤버 변수를 초기화된 상태로 만들어줘야함
                this.x = x;
                this.y = y;
                this.testA = "초기화";
                this.testB = "초기화";
            }

            public Point (int x, int y, string test) // 생성자 오버로딩
            {
                this.x = x;
                this.y = y;
                this.testA= test;
                this.testB= test;
            }
        }
    }
}
