using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P292
    {
        class Product
        {
            private static int count = 0;
            public readonly int id;        // readonly를 붙인 클래스변수는 선언과 생성자 메서드에서만 값 변경가능 const랑 같은 기능 
            public string name;
            public int price;

            public Product (string name, int price)
            {
                id = count++;
                this.name = name;
                this.price = price;
            }
            public void Show()
            {
                Console.WriteLine("id : "+id);
                Console.WriteLine("name : "+name);
                Console.WriteLine("price : "+price);
            }
        }
        static void Ma1in(string[] args)
        {
            Product product = new Product("감자", 2000);
            Product product1 = new Product("고구마", 3000);
            product.Show();
            product1.Show();
        }
    }
}
