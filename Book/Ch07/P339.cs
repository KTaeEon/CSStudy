using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P339
    {
        class Animal
        {
            private void Private() { }
            protected void Protected() { }
            public void Public() { }

            public void TestA()
            {
                // 클래스 내부 메서드에선 다 호출 가능
                Private();
                Protected();
                Public();
            }
        }

        class Dog : Animal
        {
            public void TestB()
            {
                // 상속받은 클래스에선 private 접근제한자가 붙은 멤버는 사용불가능
                Protected();
                Public();
            }
        }

        static void M1ain(string[] args)
        {
            // 상속받지않은 외부접근자는 public 접근제한자 멤버만 사용가능

            Dog dog = new Dog();
            dog.Public();
        }
    }
}
