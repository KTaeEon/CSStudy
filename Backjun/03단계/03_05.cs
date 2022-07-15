using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._03단계
{
    internal class _03_05
    {
        static void M1in(string[] args)
        {
            StringBuilder sb = new StringBuilder(); 

            int a = int.Parse(Console.ReadLine());

            for ( int i = 1; i <= a; i++)
            {
                sb.AppendLine(i.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
