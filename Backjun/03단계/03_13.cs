using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._03단계
{
    internal class _03_13
    {
        static void Ma1in(string[] args)
        {
            while(true)
            {
                string str = Console.ReadLine();
                if ( str == null)
                {
                    break;
                }
                string[] AB = str.Split();
                int A = int.Parse(AB[0]);
                int B = int.Parse(AB[1]);

                Console.WriteLine(A+B);
            }
        }
    }
}
