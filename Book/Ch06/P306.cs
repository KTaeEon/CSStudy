using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P306
    {
        static void Mai1n(string[] args)
        {
            Mai1n(new string[0]); // 이는 재퀴 메서드로  메서드 내부에서 자신의 메서드를 호출
                                 // 단 종료조건이 없을 시 무한 반복을 하게 됨
        }
    }
}
