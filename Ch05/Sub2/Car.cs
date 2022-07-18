using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub2
{
    internal class Car // class 란 구조체(객체를 생성하는 틀)를 정의함
    {
        // class로 현실객체를 정의하기 위해선 필드(속성)와 메서드(기능)을 정할필요가 있음 
        // 속성과 기능은 class 의 멤버이다.
        // 속성(필드)
        private string name;
        private string color;
        private int speed;

        // Getter, Setter : C#에서 '프로퍼티'라고 함
        public string Name
        {
            get => name; 
            set => name = value; 
        }
        public string Color 
        {
            get => color;
            set => color = value;
        }
        public int Speed  // Getter, Setter의 커스텀
        { 
            get => speed;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("speed는 0보다 작을 수 없습니다.");
                    speed = 0;
                }
                else
                {
                    speed = value;
                }
            } 
        }
        // 생성자
        public Car()
        {
            // 기본 생성자
        }

        public Car(string name, string color, int speed)
        {
            this.Name = name;
            this.Color = color;
            this.Speed = speed;
        }

        // 기능(메서드)
        public void SpeedUp(int speed)
        {
            this.Speed += speed;
        }

        public void SpeedDown(int speed)
        {
            this.Speed -= speed;
        }

        public void Show()
        {
            Console.WriteLine("==================");
            Console.WriteLine("차량명 : "+this.Name);
            Console.WriteLine("차량색 : "+this.Color);
            Console.WriteLine("현재속도 : "+this.Speed);
            Console.WriteLine("------------------");
        }




    }
}
