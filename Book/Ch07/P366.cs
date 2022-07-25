using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P366
    {
        class Animal
        {
            public virtual void Eat()
            {
                Console.WriteLine("냠냠 먹습니다.");
            }
        }

        class Dog : Animal
        {
            public new void Eat()
            {
                Console.WriteLine("강아지 사료를 먹습니다.");
            }
        }

        class Cat : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("고양이 사료를 먹습니다.");
            }
        }

        static void Ma1in(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog()
            };

            // new를 사용하여 일부 자식클래스의 메서드를 부모의 것으로 실행하고 싶을때 사용합니다.
            // Cat = override , Dog = new 했기 때문에 Dog는 하이딩중인 부모의 메서드가 호출됩니다.
            foreach (var item in animals)
            {
                item.Eat();
            }
        }
    }
}
