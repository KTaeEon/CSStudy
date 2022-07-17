using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._04단게
{
    internal class _04_07
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i< N; i++)
            {
                string[] Starr = Console.ReadLine().Split();
                double Student = int.Parse(Starr[0]);
                double Avg = 0;
                double Result = 0;
                
                for (int j = 1; j <= Student; j++)
                {
                    Avg += double.Parse(Starr[j]) / Student;
                }
                double Input = 1 / Student * 100;

                for (int k = 1; k <= Student; k++)
                {
                    if (Avg < int.Parse(Starr[k]))
                    {
                        Result += Input;
                    }
                }
                Console.WriteLine("{0:.000}"+"%",Result);
            }
        }
    }
}
