using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._06단계
{
    internal class _06_07
    {
        public static int res(int n)
        {
            string str1;
            string str2;
            string str3;
            string result;

            str1 = (n / 100).ToString();
            str2 = ((n / 10) % 10).ToString();
            str3 = (n % 10).ToString();

            result = str3 + str2 + str1;
            int res = int.Parse(result);
            return res;

        }
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int[] arr = new int[2];
            arr[0] = int.Parse(str[0]);
            arr[1] = int.Parse(str[1]);
            int m = res(arr[0]);
            int s = res(arr[1]);
            if ( m < s )
            {
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine(m);
            }
        }
    }
}
