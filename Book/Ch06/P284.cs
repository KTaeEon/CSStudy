﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P284
    {
        class Program
        {
            class Product
            {
                // static 클래스 변수 생성

                public static int counter = 0;
                public int id;
                public string name;
                public int price;

                // 생성자로 클래스 변수 counter를 1 증가시킴
                public Product(string name, int price)
                {
                    Product.counter = counter + 1;
                    this.id = counter;
                    this.name = name;
                    this.price = price;
                }
            }

            static void Mai1n(string[] args)
            {
                Product productA = new Product("감자", 2000);
                Product productB = new Product("고구마", 3000);

                Console.WriteLine(productA.id+ ":" + productA.name);
                Console.WriteLine(productB.id+ ":" + productB.name);
                Console.WriteLine(Product.counter +"개 생성되었습니다.");
            }
        }
    }
}
