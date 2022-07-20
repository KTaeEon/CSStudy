using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class SamSungRemoteControl : IRomoteControl
    {
        public void ChDown()
        {
            Console.WriteLine("SamSung ChDown...");
        }

        public void ChUp()
        {
            Console.WriteLine("SamSung ChUp...");
        }

        public void PowerOff()
        {
            Console.WriteLine("SamSung PowerOff...");
        }

        public void PowerOn()
        {
            Console.WriteLine("SamSung PowerOn...");
        }

        public void SoundDown()
        {
            Console.WriteLine("SamSung SoundDown...");
        }

        public void SoundUp()
        {
            Console.WriteLine("SamSung SoundUp...");
        }
    }
}
