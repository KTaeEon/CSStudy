using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub1
{
    internal class Car // class 란 구조체(객체를 생성하는 틀)를 정의함
    {
        // class로 현실객체를 정의하기 위해선 필드(속성)와 메서드(기능)을 정할필요가 있음 
        // 속성과 기능은 class 의 멤버이다.
        // 속성(필드)
        public string name;
        public string color;
        public int speed;

        // 기능(메서드)
        public void SpeedUp(int speed)
        {
            this.speed += speed;
        }

        public void SpeedDown(int speed)
        {
            this.speed -= speed;
        }

        public void Show()
        {
            Console.WriteLine("==================");
            Console.WriteLine("차량명 : "+this.name);
            Console.WriteLine("차량색 : "+this.color);
            Console.WriteLine("현재속도 : "+this.speed);
            Console.WriteLine("------------------");
        }




    }
}
