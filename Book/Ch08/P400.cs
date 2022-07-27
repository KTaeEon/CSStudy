using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class P400
    {
        class SquareCalculator
        {
            public int this[int i]
            {
                get
                {
                    return i * i;
                }
            }
        }

        class Program
        {
            static void Ma1in(string[] args)
            {
                SquareCalculator square = new SquareCalculator();
                Console.WriteLine(square[10]);
            }
        }
    }
}
