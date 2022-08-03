using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._10단계
{
    internal class _10_01
    {
        static void Mai1n(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int n = int.Parse(arr[0]);
            int m = int.Parse(arr[1]);
            string[] arr2 = Console.ReadLine().Split();
            List<int> list = new List<int>();

            foreach (var item in arr2)
            {
                list.Add(int.Parse(item));

            }
        }
    }
}
