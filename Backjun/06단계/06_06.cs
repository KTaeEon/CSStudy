using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._06단계
{
    internal class _06_06
    {
        static void Ma1in(string[] args)
        {
            string str = Console.ReadLine();
            string[] arr = str.Split();
            int count = 0;
            int no = 0;

            foreach (var s in arr)
            {
                count++;
            }
            
            for (int i = 0; i < count; i++)
            {
                if( arr[i] == "")
                {
                    no++;
                }
            }
            count -= no;
            Console.WriteLine(count);
        }
    }
}
