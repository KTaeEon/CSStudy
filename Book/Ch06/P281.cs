using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P281
    {
        class Program
        {
            class Test
            {
                public void TestMethod()
                {
                    Program.Ma1in(new string[] { "" });
                }
            }

            public void TestMethod()
            {
                Program.Ma1in(new string[] { "" });
            }

            static void Ma1in(string[] args)
            {

            }
            // private 메서드는 외부에서 접근이 불가능하지만 내부에선 접근이 가능하다.
        }
    }
}
