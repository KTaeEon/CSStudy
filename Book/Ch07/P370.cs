using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P370
    {
        class Parent
        {
            public virtual void Test() { }
        }

        class Child : Parent
        {
            public sealed override void Test() { }
        }

        class GrandChild : Child
        {
           // public override void Test() { } < - 여기서 오류 발생 sealed 메서드로 변경하였기 때문
        }
    }
}
