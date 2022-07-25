using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P352
    {
        class Parent
        {
            public Parent()
            {
                Console.WriteLine("부모 생성자");
            }
        }

        class Child : Parent
        {
            public Child() : base() // base 키워드를 사용한 생성자 지정
            {
                Console.WriteLine("자식 생성자");
            }
        }

        static void Ma1in(string[] args)
        {
            Child child = new Child(); // 자식 인스턴스 생성
        }
    }
}
