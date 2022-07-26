using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._07단계
{
    internal class _07_05
    {
        static void Ma1in(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] j = new int[3];

            for ( int i = 0; i < N; i++)
            {
                string[] arr = Console.ReadLine().Split();
                j[0] = int.Parse(arr[0]); // 층수
                j[1] = int.Parse(arr[1]); // 길이
                j[2] = int.Parse(arr[2]); // 몇번째

                int x = j[2] / j[0];  // 호수
                int z = j[2] % j[0];  // 층

                if (z == 0 && x < 10)
                {
                    Console.WriteLine("{0}0{1}", j[0], x);
                }
                else if (z == 0)
                {
                    Console.WriteLine("{0}{1}", j[0], x);
                }
                else if( x < 9)
                {
                    Console.WriteLine("{0}0{1}", z, x+1 );
                }
                else
                {
                    Console.WriteLine("{0}{1}", z, x+1); 
                }

            }
        }

    }
}
