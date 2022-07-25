using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._07단계
{
    internal class _07_03
    {
        public static int res(int n)
        {
            int x = 0;
            if (n == 1)
            {
                return 2;
            }
            else
            {
                for (int i = 2; i < int.MaxValue; i++)
                {
                    if (n <= (i * (i - 1)) / 2)
                    {
                        x = i;
                        break;
                    }
                }
            }
            return x;
            
        }
        static void M1ain(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = res(n);
            int y = (x * (x - 1)) / 2;
            int z = y - n;
            int b = (x - 1 - z);
            int c = (x - b);

            if (x % 2 != 0)
            {
                Console.WriteLine("{0}/{1}",b,c);
            }
            else
            {
                Console.WriteLine("{0}/{1}",c,b);
            }
            
        }
    }
}
