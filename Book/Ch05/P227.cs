using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P227
    {
        class Product // Product 라는 하나의 구조체를 생성
        {
            public string name;
            public int price;
        }

        static void Main(string[] args)
        {
            // Product 구조체를 가진 객체를 생성 및 초기화
            Product productA = new Product() { name = "감자", price = 2000 };  
            Product productB = new Product() { name = "고구마", price = 3000 };
        }
    }
}
