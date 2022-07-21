using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._06단계
{
    internal class _06_04
    {
        static void Ma1in(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < t; i++)
            {
                string str = Console.ReadLine();
                string[] arr = str.Split();
                int r = int.Parse(arr[0]);
                char[] arr2 = arr[1].ToCharArray();
                for (int j = 0; j < arr2.Length; j++)
                {
                    for ( int k = 0; k < r; k++)
                    {
                        sb.Append(arr2[j]);
                    }
                }
                sb.Append("\n");
            }
            Console.WriteLine(sb);
        }
    }
}
