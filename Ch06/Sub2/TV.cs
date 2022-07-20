using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    // C#은 두개의 부모클래스를 가질 수 없음 ( 단, interface를 통해 부모클래스, 인터페이스로 다중상속 가능 * 코드 복잡해짐 * )
    internal class TV : Internet, Computer
    {
        public void PowerOn()
        {
            Console.WriteLine("TV PowerOn...");
        }

        public void AccessInternet()
        {
            base.Access();
        }

        public void Booting()
        {
            Console.WriteLine("TV Booting...");
        }
    }
}
