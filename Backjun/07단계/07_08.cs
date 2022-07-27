using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._07단계
{
    internal class _07_09
    {
        static void Ma1in(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            List<char> list1 = new List<char>(arr[0].ToCharArray());
            List<char> list2 = new List<char>(arr[1].ToCharArray());
            int o = 0;
            int p = 0;
            int x = list1.Count - list2.Count;
            if( x < 0)
            {
                for( int j = 0; j < (Math.Abs(x)); j++)
                {
                    list1.Insert(0, '0');
                }
            }
            else if ( x > 0 )
            {
                for (int j = 0; j < x; j++)
                {
                    list2.Insert(0, '0');
                }
            }
            List<int> list3 = new List<int>();
            for (int k = list1.Count - 1; k >= 0; k--)
            {
                int z = int.Parse(list1[k].ToString()) + o;
                int y = int.Parse(list2[k].ToString());
                o = 0;
                if (k == 0)
                {
                    list3.Insert(0, (z + y));
                    break;
                }
                if (z + y >= 10)
                {
                    o = (z + y) / 10;
                    p = (z + y) % 10;
                    list3.Insert(0, p);
                }
                else
                {
                    list3.Insert(0, (z + y));
                }
            }
            foreach(var i in list3)
            {
                Console.Write(i);
            }
        }
    }
}
