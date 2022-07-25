using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P359
    {
        class Parent
        {
            public void Method() // 자식클래스에게 하이딩 되는 메서드
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            public void Method() // 메서드 하이딩
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        // 메서드 하이딩은 상속받는 클래스의 메서드와 동일한 메서드이름으로 만들어 상속메서드를 가려버리는 걸 말함

        static void Mai1n(string[] args)
        {
            Child child = new Child();
            child.Method();
            ((Parent)child).Method();
        }
    }
}
