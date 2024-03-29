﻿using Ch05.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/18
 * 이름 : 김태언
 * 내용 : 캡슐화 실습하기 교재 p203
 * 
 * 캡슐화(Encapsulation)
 *  - 캡슐화는 객체의 내용(필드)을 외부에서 참조하지 못하도록 객체의 정보(필드)를 은닉하는 특성
 *  - 캡슐화를 위한 접근 제한자 public, private, protected를 사용
 *  - 은닉된 정보의 안전한 제공을 위해 Getter, Setter를 사용(프로퍼티)
 */
namespace Ch05
{
    internal class _2_캡슐화
    {
        // 캡슐화는 객체의 내용을 외부에서 알지 못하도록 객체 정보를 은닉하는 특성을 이야기한다.
        // 캡슐화를 위해 접근 제한자(public, private, protected)를 제공한다.
        // 은닉된 정보의 안전한 제공을 위해 Getter와 Setter를 제공해야 한다.
        // 캡슐화가 안되어있는 객체는 구조체의 필드가 노출되어 취약하다.

        static void Ma1in(string[] args)
        {
            // 객체 생성
            Account kb = new Account("국민은행", "101-12-1010", "김유신", 10000);

            // 초기화

            // 객체 활용
            kb.Deposit(40000);
            kb.Withdraw(5000);

            // 캡슐화로 취약코드 예방
            // kb.balance--;

            kb.Show();

            // Car 객체 생성과 초기화
            Car sonata = new Car("소나타", "흰색", 0);

            // Car 객체 활용
            sonata.SpeedUp(80);
            sonata.SpeedDown(20);
            sonata.Show();

            // Getter, Setter 활용
            Car bmw = new Car();

            bmw.Name = "BMW 520";
            bmw.Color = "남색";
            bmw.Speed = -10;

            Console.WriteLine("sonata name : "+ bmw.Name);
            Console.WriteLine("sonata color : "+ bmw.Color);
            Console.WriteLine("sonata speed : "+ bmw.Speed);



        }
    }
}
