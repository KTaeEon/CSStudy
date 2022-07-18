using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub2
{
    internal class Account
    {
        // 속성 : private 선언으로 캡슐화
        private string bank;
        private string id;
        private string name;
        private int balance;

        // 생성자 : 캡슐화된 속상을 초기화하기 위한 메서드
        public Account(string bank, string id, string name, int balance)
        {
            this.bank = bank;
            this.id = id;
            this.name = name;
            this.balance = balance;
        }

        // 기능 : 일반적으로 외부에 기능제공이 목적이기 때문에 public 선언
        public void Deposit(int money)
        {
            this.balance += money;
        }

        public void Withdraw(int money)
        {
            this.balance -= money;
        }

        public void Show()
        {
            Console.WriteLine("==================");
            Console.WriteLine("은행명 : "+ this.bank);
            Console.WriteLine("계좌번호 : "+this.id);
            Console.WriteLine("입금주 : "+this.name);
            Console.WriteLine("현재잔액 : "+this.balance);
            Console.WriteLine("------------------");
        }

    }
}
