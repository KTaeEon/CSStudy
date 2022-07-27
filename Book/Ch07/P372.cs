using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P372
    {
        abstract class Parent
        {
            public abstract void Test();
        }

        class Child : Parent  // 상속받는 클래스는 abstract 메서드를 필수로 오버라이딩해야한다.
        {
            public override void Test()
            {
                
            }
        }
    }
}
