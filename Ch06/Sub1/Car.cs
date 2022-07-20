using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    // abstract은 class를 추상클래스로 선언한다.
    // 추상클래스 : 추상메서드를 갖는 클래스
    internal abstract class Car
    {
        // 속성
        protected string name;
        protected string color;
        protected int speed;

        // 생성자
        protected Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }

        // 기능
        public abstract void SpeedUp(int speed);
        public abstract void SpeedDown(int speed);
        
        // 추상클래스여도 실체메서드도 구현함
        public virtual void Show()
        {
            Console.WriteLine("=================");
            Console.WriteLine("차량명 : "+name);
            Console.WriteLine("차량색 : "+color);
            Console.WriteLine("현재속도 : "+speed);
            Console.WriteLine("-----------------");
        }
    }
}
