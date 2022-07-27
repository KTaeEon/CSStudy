using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class P395
    {
        class Wanted <T> // 제네릭 T 식별자는 받아오는 값의 식별자를 따라간다.
        {
            public T value;
            public Wanted(T value)
            {
                this.value = value;
            }
        }

        class Program
        {
            static void Ma1in(string[] args)
            {
                Wanted<string> wantedString = new Wanted<string>("String");
                Wanted<int> wantedInt = new Wanted<int>(52273);
                Wanted<double> wantedDouble = new Wanted<double>(52.273);

                Console.WriteLine(wantedString.value);
                Console.WriteLine(wantedInt.value);
                Console.WriteLine(wantedDouble.value);

            }
        }
    }
}
