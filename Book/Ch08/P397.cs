using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class P397
    {
        class Test<T, U>  // 제네릭의 모든 자료형을 허용하고 싶은 게 아닐 경우 where 키워드로 선별가능
                        where T : class
                        where U : struct
        {

        }
    }
}
