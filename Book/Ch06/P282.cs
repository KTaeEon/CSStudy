using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P282
    {
        class Test
        {
            public void TestMethod()
            {
                Program.Ma1in(new string[] { "" });
            }
        }
        
        class Program
        {
            // 접근 권한자를 public 으로 설정함에 따라 외부 접근이 허용됨
            public static void Ma1in(string[] args)
            {

            }
        }
    }
}
