﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._01_08
{
    internal class _01_08
    {
        static void Mai1n(string[] args)
        {
            int n = 5;

            for (  int i = 0; i < n; i++)
            {
                for(int j = 1; j < 5 - i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= (2 * i + 1) ;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
