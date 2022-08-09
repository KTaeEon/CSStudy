using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solo
{
    internal class MainConsole
    {
        public static void Main(string[] args)
        {
            bool start = false;
            bool inv = false;

            int attack = 10;
            int x = 0;
            int y = 1;
            int mct = 20;
            int level = 1;
            int potion = 0;
            int stage = 1;

            float exp = 0;
            float max = 50;

            int heart = 100;
            int life = 3;

            Console.WriteLine("숨은 몬스터 잡기 게임에 오신 유저분들을 환영합니다 !");
            Thread.Sleep(1000);
            Console.WriteLine("유저분들은 이제 맵에서 숨어있는 20마리 몬스터를 찾아야합니다 !");
            Thread.Sleep(1000);
            Console.WriteLine("총 체력과 목숨이 주어지며 몬스터를 잡을때마다 경험치를 획득합니다.");
            Thread.Sleep(1000);
            Console.WriteLine("몬스터 처치시 일정확률로 포션을 드랍합니다.");
            Thread.Sleep(1000);
            Console.WriteLine("열심히 생존하여 최대한 많이 잡아보세요 !");
            Thread.Sleep(1000);
            Console.WriteLine("                1) 모험 시작");
            Console.WriteLine("                2) 게임 종료");
            Console.Write("                입력 : ");
            string f = Console.ReadLine();

            switch (f)
            {
                case "1":
                    start = true;
                    break;
                case "2":
                    Console.WriteLine("게임을 종료합니다. 안녕히가세요!");
                    start = false;
                    break;
            }
            Random rand = new Random();
            List<Monster> list = new List<Monster>();

            for (int i = 0; i < mct; i++)
            {
                list.Add(new Monster(rand.Next(1, 70), rand.Next(1, 20)));
            }

            ConsoleKeyInfo key;

            while (start)
            {
                Console.Clear();
                if(mct == 0)
                {
                    Clear(ref x, ref y, ref heart, ref life, ref mct, ref list, ref stage);
                }
                if (x <= 2)
                {
                    x = 2;
                }
                else if (x >= 70)
                {
                    x = 70;
                }
                if (y < 2)
                {
                    y = 2;
                }
                else if (y >= 20)
                {
                    y = 20;
                }

                for (int i = 0; i <= 21; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("─────────────────────────────────────────────────────────────────────────────────────────");
                        Console.WriteLine($"  현재 체력 : {heart}   남은 목숨 : {life} L   현재 공격력 : {attack}   남은 몬스터 {mct}마리  현재 레벨 Lv" + level);
                        Console.WriteLine("─────────────────────────────────────────────────────────────────────────────────────────");
                    }
                    else if (i == 1)
                    {
                        Console.WriteLine(" ┌───────────────────────────────────────────────────────────────────────┐ 조작키 : W S A D ㅣ 인벤토리 : i");
                    }
                    else if (i == y)
                    {
                        Console.WriteLine(" {0, 1}{1," + x + "} {2, " + (71 - x) + "}", '│', 'P', '│');
                    }
                    else if (i == 21)
                    {
                        Console.WriteLine(" └───────────────────────────────────────────────────────────────────────┘");
                    }
                    else
                    {
                        Console.WriteLine(" {0, 0} {1, 71}", '│', '│');
                    }
                }
                if (inv)
                {
                    Console.WriteLine("현재남은 포션 : {0}개", potion);
                }

                for (int i = 0; i < 20; i++)
                {
                    bool ft = list[i].Mob(x, y);
                    if (ft)
                    {
                        bool di = list[i].Fight(attack, ref heart, ref life, ref potion, ref exp, ref mct);
                        list[i].die = di;
                    }
                }

                if (exp >= max)
                {
                    level++;
                    exp = exp % max;
                    max += 10f;
                    attack += 3;
                    Console.WriteLine("레벨 업 !");
                    Console.WriteLine("공격력이 3 증가합니다.");
                }

                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.A:
                        x--;
                        break;
                    case ConsoleKey.D:
                        x++;
                        break;
                    case ConsoleKey.W:
                        y--;
                        break;
                    case ConsoleKey.S:
                        y++;
                        break;
                    case ConsoleKey.I:
                        if (inv)
                        { inv = false; }
                        else
                        { inv = true; }
                        break;

                }
            }
        }

        public static void Clear(ref int x, ref int y, ref int heart, ref int life, ref int mct, ref List<Monster> list, ref int stage)
        {
            Console.WriteLine("몬스터를 다 잡으셨군요 ! 축하합니다!");
            Console.WriteLine("단계를 더 높혀서 진행하시겠습니까 ?");
            Console.WriteLine("1) 네. 단계를 높혀서 진행하겠습니다.");
            Console.WriteLine("2) 아니요. 여기까지 할게요.");
            Er:
            string str = Console.ReadLine();
            if (str == "1")
            {
                x = 0;
                y = 1;
                heart = 100;
                life = 3;
                mct = list.Count + 5;
                stage++;
                Console.WriteLine("난이도 2");
            }
            else if (str == "2")
            {
                Console.WriteLine("고생하셨습니다. 안녕히계세요 !");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("올바르지 못한 값 입니다. 다시 입력해주세요.");
                goto Er;
            }
        }
    }
}
