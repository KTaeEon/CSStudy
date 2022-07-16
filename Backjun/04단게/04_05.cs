using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjun._04단게
{
    internal class _04_05
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();
            double[] input = new double[N];
            double[] output = new double[N];
            double answer = 0;
            double per = 0;


            for (int i = 0; i < N; i++)
            {
                input[i] = double.Parse(arr[i]);
                if (per < input[i])
                {
                    per = input[i];
                }
            }
            for (int j = 0; j < N; j++)
            {
                output[j] = input[j] / per * 100;
                answer += output[j];
            }
            answer = answer / N;
            Console.WriteLine(answer);
        }
    }
}
