using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._03단계
{
    internal class _03_14
    {
        static void Ma1in(string[] args)
        {

            string N = Console.ReadLine();
            int K = int.Parse(N);
            int Count = 0;


            while(true)
            {
                Count++;
                int A = K / 10;
                int B = K % 10;
                K = A + B;
                string C = B.ToString() + (K % 10).ToString();
                K = int.Parse(C);

                if (K == int.Parse(N))
                {
                    break;
                }
            }
            Console.WriteLine(Count);
        }
    }
}
