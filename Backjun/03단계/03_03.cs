using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._03단계
{
    internal class _03_03
    {
        static void M1ain(string[] args)
        {
            string str = Console.ReadLine();
            int a = int.Parse(str);

            Console.WriteLine(res(a));
        }
        
        public static int res(int n)
        {
            if(n <= 1)
            {
                return 1;
            }
            return n + res(n - 1);
        }
    }
}
