using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._03단계
{
    internal class _03_01
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int a = int.Parse(str);

            for (int i = 1; i <= 9; i++)
            {
                int j = a * i;
                Console.WriteLine("{0} * {1} = {2}",a,i,j);
            }
        }

    }
}
