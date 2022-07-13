using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P147
    {
        static void Main1(string[] args)
        {
            ConsoleKeyInfo info = Console.ReadKey();

            // 방향키를 인식하여 나오는 출력 값을 설정

            switch(info.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("위로 이동");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("오른쪽으로 이동");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("아래로 이동");
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("왼쪽으로 이동");
                    break;
                default:
                    Console.WriteLine("다른 키를 눌렀습니다.");
                    break;
            }
        }

    }
}
