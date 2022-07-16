using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._04단게
{
    internal class _04_02
    {
        static void Main(string[] args)
        {
            int[] arr = new int[9];
            int count = 0;
            int A1 = 0;

            for(int i = 0; i < 9; i++)
            {
                string str = Console.ReadLine();
                arr[i] = int.Parse(str);

                if ( A1 <= arr[i])
                {
                    A1 = arr[i];
                    count = i + 1;
                }
            }
            Console.WriteLine(A1);
            Console.WriteLine(count);
        }
    }
}
