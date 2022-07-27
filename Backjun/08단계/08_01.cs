using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._08단계
{
    internal class _08_01
    {
        static void Main(string[] args)
        {
            int count = 0;
            List<int> list = new List<int>();
            int n = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();


            for (int i = 0; i < n; i++)
            {
                list.Insert(i, int.Parse(arr[i]));
            }

            for (int j = 0; j < list.Count; j++)
            {
                int x = list[j];
                
                if( x == 1)
                {

                }
                else if(x == 2 || x == 3 || x == 5 || x == 7)
                {
                    count++;
                }
                else if ((x % 10) == 1 || (x % 10) == 3 || (x % 10) == 7 || (x % 10) == 9)
                {
                    if ((x % 2) == 0 || (x % 3) == 0 || (x % 5) == 0 || (x % 7) == 0)
                    {

                    }
                    else
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
