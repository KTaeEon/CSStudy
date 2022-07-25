using Book.Ch07.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P348
    {
        static void Ma1in(string[] args)
        {
            List<Animal> Animals = new List<Animal>() { new Dog(), new Cat() };

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();

                if (item is Dog) { ((Dog)item).Bark(); }   // 일반적인 자료형 변환
                if (item is Cat) { ((Cat)item).Meow(); }   // 일반적인 자료형 변환
            }
            Console.WriteLine();


            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();

                if (item is Dog) { (item as Dog).Bark(); }   // as 키워드를 사용한 자료형 변환
                if (item is Cat) { (item as Cat).Meow(); }   // as 키워드를 사용한 자료형 변환
            }
            Console.WriteLine();
            
            // as 키워드를 사용한 일반적인 형태
            foreach ( var item in Animals)
            {
                item.Eat();
                item.Sleep();

                var dog = item as Dog;
                if (dog != null) { dog.Bark(); }

                var cat = item as Cat;
                if (cat != null) { cat.Meow(); }
            }


        }
    }
}
