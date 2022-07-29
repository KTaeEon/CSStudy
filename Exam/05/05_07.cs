using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/28
 * 이름 : 김태언
 * 내용 : 예외처리 연습문제
 */
namespace Exam._05
{
    internal class _05_07
    {
        static void Mai1n(string[] args)
        {
            while (true)
            {
                Game();
                Console.WriteLine("-----------------");
                Console.WriteLine("0:종료, 1:한번 더하기");
                Console.Write("입력 : ");

                int answer = int.Parse(Console.ReadLine());

                if(answer == 0)
                {
                    break;
                }
            }
            Console.WriteLine("게임종료...");
        }

        public static void Game()
        {
            string[] words = { "가위", "바위", "보" };

            bool x = true;
            string comWord = null;
            string youWord = null;

            while (x)
            {
                Console.Write("가위, 바위, 보 입력 : ");

                try
                {
                    youWord = Console.ReadLine();
                    if (!words.Contains(youWord))
                    {
                        throw new Exception("가위, 바위, 보 중에서 하나만 내세요.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                break;
            }

            Random random = new Random();
            comWord = words[random.Next(3)];

            Console.WriteLine("컴퓨터 결과 : " + comWord);

            if (comWord == youWord)
            {
                Console.WriteLine("무승부");
            }
            else if (comWord == words[0] && youWord == words[1])
            {
                Console.WriteLine("당신의 승리!");
            }
            else if (comWord == words[1] && youWord == words[2])
            {
                Console.WriteLine("당신의 승리!");
            }
            else if (comWord == words[2] && youWord == words[0])
            {
                Console.WriteLine("당신의 승리!");
            }
            else
            {
                Console.WriteLine("컴퓨터 승리!");
            }
        }
    }
}
