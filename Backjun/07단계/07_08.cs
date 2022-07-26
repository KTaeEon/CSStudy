using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._07단계
{
    internal class _07_09
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            char[] cha1 = new char[19];
            char[] cha2 = new char[19];

            for ( int i = 19; i < 0; i--)
            {
                int count = 0;
                int t = (int.Parse(cha1[i].ToString() + int.Parse(cha2[i].ToString())));
                if (t <= 10)
                {
                    count += t / 10;
                    t = (t % 10);
                }
            }
            long N = long.Parse(arr[0]); 
            long X = long.Parse(arr[1]);

            Console.WriteLine(N + X);

        }
    }
}
