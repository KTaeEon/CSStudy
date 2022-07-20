using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class P285
    {
        class Program
        {
            class Hidden
            {
                private Hidden() { }
            }
            static void Ma1in(string[] args)
            {
                // Hidden hidden = new Hidden(); 을 할시 에러가 발생함
            }
        }

    }
}
