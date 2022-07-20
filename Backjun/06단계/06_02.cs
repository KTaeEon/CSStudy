using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._06단계
{
    internal class _06_02
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string r = Console.ReadLine();
            char[] ch = r.ToCharArray();
            int result = 0;
            
            for (int i = 0; i < n; i++)
            {
                r = ch[i].ToString();
                result += int.Parse(r);
            }
            Console.WriteLine(result);
        }
    }
}
