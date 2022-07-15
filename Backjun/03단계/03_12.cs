using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._03단계
{
    internal class _03_12
    {
        static void Ma1in(string[] args)
        {
            bool status = true;
            while(status)
            {
                string[] str = Console.ReadLine().Split();
                int A = int.Parse(str[0]);
                int B = int.Parse(str[1]);
                
                if ( A <= 0 && B <= 0)
                {
                    status = false;
                }
                else
                {
                    Console.WriteLine(A+B);
                }
            }
        }
    }
}
