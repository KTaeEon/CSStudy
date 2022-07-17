using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._04단게
{
    internal class _04_06
    {
        static void Ma1in(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] starr = new string[N];

            for ( int i = 0; i < N; i++)
            {
                starr[i] = Console.ReadLine();
                char[] charr = starr[i].ToCharArray();
                int count = 0;
                int result = 0;

                for ( int j = 0; j < starr[i].Length; j++)
                {
                    if (charr[j] == 'O')
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }
                    result += count;
                }
                Console.WriteLine(result);
            }
        }
        
    }
}
