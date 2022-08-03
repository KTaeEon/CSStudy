using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._08단계
{
    internal class _08_04
    {
        static void Ma1in(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int M = int.Parse(str[0]);
            int N = int.Parse(str[1]);

            for(int i = M; i <= N; i++)
            {
                int count = 0;
                for (int j = 2; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        count++;
                    }
                }
                if ( count == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
