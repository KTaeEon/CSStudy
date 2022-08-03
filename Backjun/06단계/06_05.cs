using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._06단계
{
    internal class _06_05
    {
        static void Main(string[] args)
        {
            List<char> list = new List<char>();
            string str = Console.ReadLine();
            char[] arr = str.ToUpper().ToCharArray();
            
            foreach(char c in arr)
            {
                list.Add(c);
            }
            list.Sort();
            int count = 0;
            int max = 0;
            char chr = '-';
            char log = '-';
            foreach (char c in list)
            {
                if(count == 0)
                {
                    log = c;
                }
                if(log == c)
                {
                    count++;
                    if(max < count)
                    {
                        max = count;
                        chr = log;
                    }
                }
                else if (log != c)
                {
                    if(max == count)
                    {
                        chr = '?';
                    }
                    count = 0;
                }
            }
            Console.WriteLine(chr);
        }
    }
}
