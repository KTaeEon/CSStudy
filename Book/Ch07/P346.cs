using Book.Ch07.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P346
    {
        static void Ma1in(string[] args)
        {
            List<Animal> Animals = new List<Animal>() { new Dog(), new Cat() };

            foreach ( var item in Animals)
            {
                item.Eat();
                item.Sleep();

                if (item is Dog) { } // 객체 타입 확인 키워드
                if (item is Cat) { } // 객체 타입 확인 키워드

            }
        }
    }
}
