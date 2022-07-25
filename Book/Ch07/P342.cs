using Book.Ch07.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P342
    {
        static void M1ain(string[] args)
        {
            // 하나의 리스트를 사용하여 코드를 간략화
            // 부모(상속) 클래스를 정의함으로서 상속받는 객체를 배열 또는 리스트에 넣을 수 있음
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog()
            };

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();
            }
            Console.WriteLine();

            foreach ( var item in Animals)
            {
                item.Eat();
                item.Sleep();
                //((Cat)item).Meow();   // 무작정 변화해서 메서드 호출 * 오류 발생
            }
        }
    }
}
