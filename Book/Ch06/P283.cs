using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P283
    {
        class Product
        {
            public string name;
            public int price;

            // 생성자 추가
            public Product(string name, int price)
            {
                this.name = name;
                this.price = price;
            }
        }
    }
}
