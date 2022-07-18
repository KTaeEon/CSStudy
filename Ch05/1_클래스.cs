﻿using Ch05.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/18
 * 이름 : 김태언
 * 내용 : 클래스 실습하기 교재 p203
 * 
 * 클래스(Class)
 *  - 클래스는 객체를 생성하는 구조체이며, 필드(속성)와 메서드(기능)로 구성된다.
 *  - 객체는 클래스의 실제 인스턴스로 new 연산을 활용해서 생성된다.
 */

namespace Ch05
{
    internal class _1_클래스
    {
        static void Ma1in(string[] args)
        {
            // 클래스를 이용하여 만든 객체(sonata)는 Stack에 저장되며 Heap에 저장된 Car라는 클래스를 참조한다.
            // 객체 생성
            Car sonata = new Car();

            // 객체 초기화
            sonata.name = "소나타";
            sonata.color = "흰색";
            sonata.speed = 0;


            // 객체 기능 활용
            sonata.SpeedUp(80);
            sonata.SpeedDown(20);
            sonata.Show();

            // 객체 생성과 초기화
            Car benz = new Car();
            benz.name = "벤츠";
            benz.color = "검정색";
            benz.speed = 0;

            benz.SpeedUp(100);
            benz.SpeedDown(20);
            benz.Show();

            // Account 객체 생성
            Account kb = new Account(); // kb라는 객체 생성
            Account wr = new Account(); // wr라는 객체 생성

            // Account 객체 초기화
            kb.bank = "국민은행";
            kb.id = "101-12-1010";
            kb.name = "김유신";
            kb.balance = 10000;

            wr.bank = "우리은행";
            wr.id = "101-22-2020";
            wr.name = "김춘추";
            wr.balance = 30000;

            // Account 객체 활용
            kb.Deposit(40000);
            kb.Withdraw(5000);
            kb.Show();

            wr.Deposit(70000);
            wr.Withdraw(50000);
            wr.Show();
        }
    }
}
