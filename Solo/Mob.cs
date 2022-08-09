using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solo
{

    public class Monster
    {
        private int xr;
        private int yr;
        public bool die = false;

        public Monster(int xr, int yr)
        {
            this.xr = xr;
            this.yr = yr;
        }


        public bool Mob(int x, int y)
        {
            if (die == false)
            {
                if (x == xr && y == yr)
                {
                    Console.WriteLine("지나가다가 몬스터를 만났습니다 !");
                    Console.WriteLine("싸우시겠습니까 ?");
                ERROR1:
                    Console.Write("1.예  2. 아니오 : ");
                    try
                    {
                        string answer = Console.ReadLine();
                        if (answer == "1" || answer == "2")
                        {
                            if (answer == "1")
                            {
                                return true;
                            }
                            else
                            {
                                Console.WriteLine("도망쳤습니다.");
                                Console.WriteLine("계속 진행하려면 아무키나 누르세요.");
                                return false;
                            }
                        }
                        else
                        {
                            throw new Exception("정확한 값이 아닙니다 다시 입력해주세요");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        goto ERROR1;
                    }
                }
            }
            return false;
        }

        public bool Fight(int attack, ref int heart, ref int life, ref int potion, ref float exp, ref int mct)
        {
            Random rand = new Random();
            int ht = rand.Next(40, 50);
            float ex = rand.Next(10, 15);
            bool res = true;
            ConsoleKeyInfo ky;
            while (res)
            {
                int at = rand.Next(13, 18);
                Console.WriteLine("몬스터 체력 : " + ht);
                Console.WriteLine("나의 체력 : " + heart);
                Console.WriteLine(" 공격 A , 방어 E , 포션 사용 H");
                Task.Delay(10000);

                while (Console.KeyAvailable)
                {                    
                    Console.ReadKey(true);           
                }

                ky = Console.ReadKey(true);

                switch (ky.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("공격 !");
                        Thread.Sleep(1000);
                        Console.WriteLine($"적에게 {attack}데미지 공격");
                        Thread.Sleep(1000);
                        ht -= attack;
                        Console.WriteLine($"적이 {at}데미지 공격");
                        Thread.Sleep(1000);
                        heart -= at;
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine("방어 !");
                        Thread.Sleep(1000);
                        int luck = rand.Next(1, 5);
                        if (luck == 2)
                        {
                            Console.WriteLine("행운 발동! 카운터 공격 !");
                            Thread.Sleep(1000);
                            Console.WriteLine("적에게 {0}데미지를 주었다", attack + 5);
                            Thread.Sleep(1000);
                            ht -= attack + 5;
                        }
                        else
                        {
                            Console.WriteLine("공격을 방어하여 {0}만큼 데미지를 입었다 !", at - 8);
                            Thread.Sleep(1000);
                            heart -= at - 8;
                        }
                        break;
                    case ConsoleKey.H:
                        if (potion > 0)
                        {
                            Console.WriteLine("포션 사용 !");
                            heart += 50;
                            if (heart > 100)
                            {
                                heart = 100;
                            }
                            Thread.Sleep(1000);

                            potion--;
                        }
                        else
                        {
                            Console.WriteLine("포션이 없습니다.");
                            Thread.Sleep(1000);

                        }
                        
                        break;
                }
                if (heart <= 0)
                {
                    Console.WriteLine("죽었습니다.");
                    Thread.Sleep(1000);
                    Console.WriteLine("라이프가 있을경우 라이프를 소모하여 부활합니다.");
                    Thread.Sleep(1000);
                    if (life > 0)
                    {
                        heart = 100;
                        life--;
                        Console.WriteLine("남은 라이프 : " + life);
                        Thread.Sleep(1000);

                    }
                    else
                    {
                        Console.WriteLine("라이프가 부족하여 부활할 수 없습니다 게임을 종료합니다");
                        Thread.Sleep(1000);
                        Console.WriteLine($"당신은 {20 - mct}마리의 몬스터를 잡았습니다.");
                        Thread.Sleep(1000);

                        Environment.Exit(0);
                    }
                }
                if (ht <= 0)
                {
                    Console.WriteLine("몬스터를 죽였습니다 !");
                    Thread.Sleep(1000);
                    Console.WriteLine($"{ex}만큼 경험치를 획득했습니다.");
                    Thread.Sleep(1000);
                    int px = rand.Next(1, 4);
                    if (px == 3)
                    {
                        Console.WriteLine("포션을 얻었습니다 !");
                        Thread.Sleep(1000);

                        potion++;
                    }
                    exp += ex;
                    mct--;
                    Console.WriteLine($"남은 몬스터 {mct}마리");
                    Thread.Sleep(1000);
                    Console.WriteLine("계속 진행하려면 아무키나 누르세요.");
                    res = false;
                    return true;
                }
            }
            return false;
        }
    }
}
