using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P295
    {
        class Box
        {
            // 변수 
            private int width;
            private int height;

            // 생성자
            public Box(int width, int height)
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

            // 인스턴스 메서드
            public int Area()
            {
                return this.width * this.height;
            }

            // 겟터(Getter)
            public int GetWidth() { return width; }
            public int GetHeight() { return width; }

            // 셋터(Setter)
            public void SetWidth(int width)
            {
                if (width > 0) { this.width = width; }
                else { Console.WriteLine("너비는 자연수를 입력해주세요."); }
            }

            public void SetHeight(int height)
            {
                if (height > 0) { this.width = height; }
                else { Console.WriteLine("높이는 자연수를 입력해주세요."); }
            }

            // 이는 안전하게 값을 넣고 빼는 것이 가능하지만 쓸데없이 코드가 길어진 느낌이 듬
            // 그래서 C#은 이를 좀 더 짧게 표현 가능한 방법이 있음
        }
    }
}
