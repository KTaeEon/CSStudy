using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._08단계
{
    internal class _08_01
    {
        static void Ma1in(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] x = Console.ReadLine().Split(" ");
            int count = 0;
            int answer = 0;

            foreach (string z in x)
            {
                int y = int.Parse(z);
                for (int i = 2; i <= y; i++)
                {
                    if (y % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    answer++;
                }
                count = 0;
            }
            Console.WriteLine(answer);
        }
    }
}
