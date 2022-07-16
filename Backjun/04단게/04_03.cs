using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._04단게
{
    internal class _04_03
    {
        static void Ma1in(string[] args)
        {
            int[] A = new int[3];
            int B;
            for (int i = 0; i < 3; i++)
            {
                int input = int.Parse(Console.ReadLine());
                A[i] = input;
            }
            B = A[0] * A[1] * A[2];

            string Str = B.ToString();
            char[] Chrarr = Str.ToCharArray();
            int[] intarr = new int[Chrarr.Length];

            for (int i = 0; i < Chrarr.Length; i++)
            {
                string str = Chrarr[i].ToString();
                intarr[i] = int.Parse(str);
            }

            for (int j = 0; j <= 9;j++)
            {
                int Count = 0;

                for(int k = 0; k < intarr.Length; k++)
                {
                    if (intarr[k] == j )
                    {
                        Count++;
                    }
                }
                Console.WriteLine(Count);

            }
        }
    }
}
