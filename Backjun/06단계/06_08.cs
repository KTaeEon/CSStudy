using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._06단계
{
    internal class _06_08
    {
        public static int Res(char ch)
        {
            int n = 0;
            if (ch == 1)
            {
                n = 2;
            }
            else if (ch == 'A' || ch == 'B' || ch == 'C')
            {
                n = 3;
            }
            else if (ch == 'D' || ch == 'E' || ch == 'F')
            {
                n = 4;
            }
            else if (ch == 'G' || ch == 'H' || ch == 'I')
            {
                n = 5;
            }
            else if (ch == 'J' || ch == 'K' || ch == 'L')
            {
                n = 6;
            }
            else if (ch == 'M' || ch == 'N' || ch == 'O')
            {
                n = 7;
            }
            else if (ch == 'P' || ch == 'Q' || ch == 'R' || ch == 'S')
            {
                n = 8;
            }
            else if (ch == 'T' || ch == 'U' || ch == 'V')
            {
                n = 9;
            }
            else if (ch == 'W' || ch == 'X' || ch == 'Y' || ch == 'Z')
            {
                n = 10;
            }
            else
            {
                n = 11;
            }
            return n;

        }
        static void Ma1in(string[] args)
        {
            string str = Console.ReadLine();
            char[] chr = str.ToCharArray();
            int a = 0;

            for(int i = 0; i < chr.Length; i++)
            {
                int n = Res(chr[i]);
                a += n;
            }
            Console.WriteLine(a);
        }
    }
}
