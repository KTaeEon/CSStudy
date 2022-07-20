using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P293
    {
        class Box
        {
            // 이 경우 int width와 int height 에 대하여 조건이 걸려있지않음 ( 음수로도 설정가능 )
            public int width;
            public int height;

            public Box(int width, int height)
            {
                this.width = width;
                this.height = height;
            }

            public int Area()
            {
                return this.width * this.height;
            }
        }

        class Box2
        {
            // if문을 사용하여 음수가 입력되는 것을 방지가능 ( 즉, 생성자에 조건을 걸어 허점보완가능 )
            public int width;
            public int height;

            public Box2(int width, int height)
            {
                if (width > 0 && height > 0)
                {
                    this.width = width;
                    this.height = height;
                }
                else
                {
                    Console.WriteLine("너비와 높이는 자연수로 초기화해주세요");
                }
            }

            public int Area2()
            {
                return this.width * this.height;
            }
        }
    }
}
