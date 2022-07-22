using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P336
    {
        // 상속 클래스를 활용함으로서 불필요한 요소를 줄일 수 있다.
        // 여러개의 객체의 동일점을 상속클래스의 멤버로 정의하면서 최적화
        class Animal
        {
            public int Age { get; set; }

            public Animal() { this.Age = 0; }

            public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
            public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
        }

        class Dog : Animal
        {
            public string Color { get; set; }

            public void Bark() { Console.WriteLine("왈왈 짖습니다."); }
        }

        class Cat : Animal
        {
            public void Meow() { Console.WriteLine("냥냥 웁니다."); }
        }

    }
}
