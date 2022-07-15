using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._03단계
{
    internal class _03_11
    {
        static void Mai1n(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int N = int.Parse(str[0]);
            int X = int.Parse(str[1]);
            string[] str1 = Console.ReadLine().Split();

            for (int i = 0; i < N;i++)
            {
                int Y = int.Parse(str1[i]);

                if (Y < X)
                {
                    Console.Write(Y +" ");
                }
            }
        }
    }
}
