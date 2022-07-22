using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P338
    {
        class Animal
        {
            public void Eat() { Console.WriteLine("냠냠 먹습니다"); }
            public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다"); }
        }

        class Dog : Animal
        {
            // 상속받은 클래스는 상속클래스의 메서드(not private)사용이 가능하다.

            public void Test()
            {
                Eat();
                Sleep();
            }
        }
    }
}
