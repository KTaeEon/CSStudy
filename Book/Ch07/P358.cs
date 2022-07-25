using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P358
    {
        class Parent
        {
            public int variable = 273;
        }

        class Child : Parent
        {
            public string variable = "shadowing";
        }

        static void M1ain(string[] args)
        {
            Child child = new Child();
            Console.WriteLine(child.variable);

            // 가려진 자료형 찾는 법
            Console.WriteLine(((Parent)child).variable); // 자료형을 Parent로 변환
        }
    }
}
