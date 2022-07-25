using Book.Ch07.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class P344
    {
        static void M1ain(string[] args)
        {
            // 최상위 클래스 Object를 활용한 다형성 예제 

            List<Object> listOfObject = new List<object>();

            listOfObject.Add(new Dog());
            listOfObject.Add(new Cat());
            listOfObject.Add(52);
            listOfObject.Add(52L);
            listOfObject.Add(52.273F);
            listOfObject.Add(52.273);
        }
    }
}
