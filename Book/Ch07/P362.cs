using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P362
    {
        class Parent
        {
            public virtual void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            public override void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        static void Ma1in(string[] args)
        {
            // 오버라이딩을 한 멤버는 자료형의 클래스를 변환해도 상속받는 메서드가 상속메서드를 완전히 덮어씌웠기 때문에 상속클래스를 호출해도 상속받는 클래스의 메서드가 호출됨.
            Child child = new Child();
            child.Method();
            ((Parent)child).Method();
        }
        
    }
}
