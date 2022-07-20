using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._05단계
{
    internal class _05_03
    {
        public static int res (int num)
        {
            int count = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i >= 1000)
                {
                    continue;
                }
                else if (i >= 100)
                {
                    b = ((i / 100) % 10);
                    c = ((i / 10) % 10);
                    d = (i % 10);
                    if((d - c) == (c - b))
                    {
                        count++;
                    }

                }
                else
                {
                    count++;
                }
            }
            return count;
        }

        static void M1ain(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result = res(num);
            Console.WriteLine(result.ToString());
        }
    }
}
