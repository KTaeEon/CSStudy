using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._06단계
{
    internal class _06_09
    {
        public static int Res(string str)
        {
            int count = 0;
            char[] ch = str.ToCharArray();

            for(int i = 0; i < ch.Length; i++)
            {
                if (i == ch.Length-1)
                {
                    count++;
                    break;
                }
                if (ch[i] == 'c')
                {
                    if (ch[i+1] == '=')
                    {
                        count++;
                        i++;
                        continue;
                    }
                    else if (ch[i+1] == '-')
                    {
                        count++;
                        i++;
                        continue;
                    }
                }
                else if (ch[i] == 'd')
                {
                    if (ch[i + 1] == 'z')
                    {
                        if (i + 1 == ch.Length - 1)
                        {
                            count++;
                            count++;
                            break;
                        }
                        else if (ch[i + 2] == '=')
                        {
                            count++;
                            i++;
                            i++;
                            continue;
                        }
                    }
                    else if (ch[i + 1] == '-')
                    {
                        count++;
                        i++;
                        continue;
                    }
                }
                else if (ch[i] == 'l')
                {
                    if (ch[i + 1] == 'j')
                    {
                        count++;
                        i++;
                        continue;
                    }
                }
                else if (ch[i] == 'n')
                {
                    if (ch[i + 1] == 'j')
                    {
                        count++;
                        i++;
                        continue;
                    }
                }
                else if (ch[i] == 's')
                {
                    if (ch[i + 1] == '=')
                    {
                        count++;
                        i++;
                        continue;
                    }
                }
                else if (ch[i] == 'z')
                {
                    if (ch[i + 1] == '=')
                    {
                        count++;
                        i++;
                        continue;
                    }
                }
                count++;
            }
            return count;
        }
        static void Ma1in(string[] args)
        {
            string str = Console.ReadLine();
            int a = Res(str);

            Console.WriteLine(a);
        }
    }
}
