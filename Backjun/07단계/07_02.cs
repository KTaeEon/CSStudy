using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._07단계
{
    internal class _07_02
    {
        static void Ma1in(string[] args)
        {
            int ar = int.Parse(Console.ReadLine());
            int S = 1;
            int N = 1;
            int A = 6;
            Hi:

            if ( ar == 1 )
            {
                Console.WriteLine(1);
            }
            else if (ar == (N + A))
            {
                S++;
                Console.WriteLine(S);
            }
            else if (ar > (N + A))
            {
                S++;
                N += A;
                A += 6;
                goto Hi;
            }
            else
            {
                S++;
                Console.WriteLine(S);
            }
        }
    }
}
