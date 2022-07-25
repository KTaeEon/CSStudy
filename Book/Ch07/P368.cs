using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P368
    {
        // sealed 클래스 오류
        sealed class Parent
        {
            public void Test() { }
        }

        class Child // : Parent sealed 클래스가 붙으면 해당 클래스는 더 이상 상속받지 못하며 오버라이딩도 불가능
        {
            public void Test() { }
        }

        static void M1ain(string[] args)
        {
            Parent parent = new Parent();
            Child child = new Child();

            parent.Test();
            child.Test();
        }
    }
}
