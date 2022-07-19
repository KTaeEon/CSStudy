using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub5
{
    internal class Eagle : Animal
    {
        string str = "응애";
        public override void Move()
        {
            Console.WriteLine("Eagle Fly...");
            Console.WriteLine("이름 : "+str);
        }
    }
}
