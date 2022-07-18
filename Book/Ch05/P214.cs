using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class P214
    {
        static void M1ain(string[] args)
        {
            // 변수를 선언합니다.
            List<int> list = new List<int>() { 52, 273, 32, 64 };

            // Remove 메서드를 사용하여 list 변수 배열의 {52} 요소를 제거합니다.
            list.Remove(52);

            // 반복을 수행합니다.
            foreach(var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\titem : " + item);
            }
        }
    }
}
