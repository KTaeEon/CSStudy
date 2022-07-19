using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._05단계
{
    internal class _05_02
    {
        public static int Result(int n)
        {
            int num = 0;
            if(n < 10)
            {
                num = n + n;
            }
            else if(n < 100)
            {
                num = n + (n / 10) + (n % 10);
            }
            else if(n < 1000)
            {
                num = n + (n / 100) + ((n % 100) / 10) + (n % 10);
            }
            else if(n < 10000)
            {
                num = n + (n / 1000) + ((n % 1000) / 100) + (((n % 1000) % 100) / 10) + (n % 10);
            }
            return num;
        }

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int a = 0;
            List<int> output = new List<int>();
            for(int i = 0; i < 10000;i++)
            {
                output.Add(i+1);
            }

            for (int j = 10000; j >= 0; j--)
            {
                a = Result(j);
                output.Remove(a);
            }
            foreach(var res in output)
            {
                sb.AppendLine(res.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
