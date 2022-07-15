using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._03단계
{
    internal class _03_07
    {
        static void Ma1in(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for ( int i = 1; i <= a; i++)
            {
                string[] str = Console.ReadLine().Split();
                int N1 = int.Parse(str[0]);
                int N2 = int.Parse(str[1]);

                sb.AppendLine($"Case #{i}: {N1 + N2}");

            }
            Console.WriteLine(sb);
        }
    }
}
 