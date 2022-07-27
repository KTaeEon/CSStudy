using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P371
    {
        abstract class Parent
        {
            public void Test() { }
        }

        class Child : Parent
        {
            public void Test() { }
        }

        static void Ma1in(string[] args)
        {
            // Parent parent = new Parent(); < 여기서 오류 발생 ( abstract 클래스는 상속만 가능 )
            Child child = new Child();

           //  parent.Test();
            child.Test();
        }
    }
}
