using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._08단계
{
    internal class _08_03
    {
        static void M1ain(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());
            bool yes = true;
            if (N == 1)
            {

            }
            else
            {
                int count = 2;
                int save = 0;
                while (yes)
                {
                    if (count == save)
                    {
                        break;
                    }
                    if(N % count == 0)
                    {
                        sb.AppendLine(count.ToString());
                        save = N;
                        N = N / count;
                    }
                    else
                    {
                        count++;
                    }
                }
                Console.WriteLine(sb);
            }
        }
    }
}
