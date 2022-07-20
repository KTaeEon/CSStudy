using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P298
    {
        class Box
        {
            // 변수와 속성
            private int width;
            public int Width
            {
                get { return width; }
                set
                {
                    if (value > 0)
                    {
                        width = value;
                    }
                    else
                    {
                        Console.WriteLine("너비는 자연수를 입력해주세요.");
                    }
                }
            }
            private int height;
            public int Height
            {
                get { return height; }
                set
                {
                    if (value > 0)
                    {
                        height = value;
                    }
                    else
                    {
                        Console.WriteLine("높이는 자연수를 입력해주세요.");
                    }
                }
            }

            // 생성자
            public Box(int width, int height)
            {
                if (width > 0)
                {
                    this.width = width;
                }
                else
                {
                    Console.WriteLine("너비는 자연수로 초기화해주세요");
                }
                if (height > 0)
                {
                    this.height = height;
                }
                else
                {
                    Console.WriteLine("높이는 자연수로 초기화해주세요");
                }
            }

            // 인스턴스 메서드
            public int Area()
            {
                return this.width * this.height;
            }
        }
        static void Ma1in(string[] args)
        {
            Box box = new Box(-10, -20);

            box.Width = -200;
            box.Height = -100;
            box.Width = 100;
            Console.WriteLine(box.Width);
        }
    }
}
