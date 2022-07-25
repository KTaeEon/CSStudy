using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._06단계
{
    internal class _06_10
    {
        static void Ma1in(string[] args)
        {
            int a = 0;

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<char> list = new List<char>();
                string st = Console.ReadLine();
                char[] cha = st.ToCharArray();
                for (int j = 0; j < st.Length; j++)
                {
                    if (j == st.Length - 1)
                    {
                        if (list.Contains(cha[j]))
                        {
                            a -= 1;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (cha[j] == cha[j + 1])
                    {
                        continue;
                    }
                    else if (list.Contains(cha[j]))
                    {
                        a -= 1;
                        break;
                    }
                    else
                    {
                        list.Add(cha[j]);
                    }
                }
                a += 1;
            }
            Console.WriteLine(a);
        }
    }
}
