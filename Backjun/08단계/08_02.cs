using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._08단계
{
    internal class _08_02
    {
        static void Ma1in(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            bool mix = true;
            int min = 0;
            int answer = 0;


            for(int i = n; i <= x; i++)
            {
                int count = 0;
                for (int j = 2; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        count++;
                    }
                    if(count == 2)
                    {
                        break;
                    }
                }
                if (count == 1 && mix == true)
                {
                    answer += i;
                    min = i;
                    mix = false;
                }
                else if ( count == 1)
                {
                    answer += i;
                }
            }
            Console.WriteLine(answer);
            Console.WriteLine(min);

        }
    }
}
