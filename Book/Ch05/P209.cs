using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P209
    {
        static void Ma1in(string[] args)
        {
            Random random = new Random();

            //NextDouble() 메서드는 0.0과 1.0사이의 난수(임의의 수) 반환
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());

            // 원하는 범위의 실수 난수 생성
            // *10 을 하여서 0.0 과 10.0사이의 난수 반환
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);
        }
    }
}
