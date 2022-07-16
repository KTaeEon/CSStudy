using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._04단게
{
    internal class _04_04
    {
        static void Ma1in(string[] args)
        {
            int[] A = new int[10];
            int[] B = new int[10];

            for (int i = 0; i <= 9; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
                B[i] = A[i] % 42;
            }

            int[] C = B.Distinct().ToArray();
            int D = C.Length;
            Console.WriteLine(D);
        }
    }
}
