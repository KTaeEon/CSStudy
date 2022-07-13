using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P172
    {
        static void Main3(string[] args)
        {
            // foreach 반복문과 배열

            // 변수를 선언합니다.
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };

            // 반복을 수행합니다.
            foreach (string item in array)
            {
                // 출력합니다.
                Console.WriteLine(item);
            }

            // 변수를 선언합니다.
            string[] array2 = { "사과", "배", "포도", "딸기", "바나나" };

            // 반복을 수행합니다.   var (자동선택) 사용 가능
            foreach(var item1 in array2)
            {
                // 출력합니다.
                Console.WriteLine(item1);
            }

        }
    }
}
