using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._04단게
{
    internal class _04_01
    {
        static void Ma1in(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();
            int[] arr2 = new int[N];

            for (int i = 0; i < N;i++)
            {
                arr2[i] = int.Parse(arr[i]);
            }

            int Min = arr2[0];
            int Max = arr2[0];

            for (int j = 0; j < N; j++)
            {
                if ( Max <= arr2[j])
                {
                    Max = arr2[j];
                }
                if (Min >= arr2[j])
                {
                    Min = arr2[j];
                }
            }
            Console.WriteLine($"{Min} {Max}");
        }
    }
}
