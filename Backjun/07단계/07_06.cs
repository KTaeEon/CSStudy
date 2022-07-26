using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._07단계
{
    internal class _07_06
    {
        static void Ma1in(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            for (int i = 0; i < T; i++)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                int[] ar = new int[k];
                int count = 0;
                if ( n == 1)
                {
                    Console.WriteLine('1');
                }
                else
                {
                    for(int o = 0; o < k; o++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            ar[o] += arr[j];
                        }
                        n--;
                    }
                    foreach (int j in ar)
                    {
                        count += j;
                    }
                    if ( k != 1)
                    {
                        count += 1;
                    }
                    Console.WriteLine(count);
                }
                
            }
        }
    }
}
