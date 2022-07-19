using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class Car
    {
        // 상속에서 자식클래스가 참조할 수 있도록 protected로 수정
        protected string name;
        protected string color;
        protected int speed;

        // 생성자
        public Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }

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
