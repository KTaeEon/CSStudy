﻿using Ch06.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/20
 * 이름 : 김태언
 * 내용 : 인터페이스 실습하기 교재 p425
 * 
 * 인터페이스(Interface)
 *  - 클래스 설계를 위해 공통의 표준 가이드 역할을 위한 구조체
 *  - 인터페이스를 활용해서 객체간 결합도를 완화
 */
namespace Ch06
{
    internal class _2_인터페이스
    {
        static void Ma1in(string[] args)
        {
            ///////////////////////////////////////////
            // 인터페이스로 공통 클래스 구조설계에 활용
            ///////////////////////////////////////////
            IRomoteControl lg      = new LGRemoteControl();
            IRomoteControl samsung = new SamSungRemoteControl();

            lg.PowerOn();
            lg.ChUp();
            lg.SoundUp();

            samsung.PowerOn();
            samsung.ChDown();
            samsung.SoundDown();


            ///////////////////////////////////////////
            // 인터페이스로 다중 상속에 활용
            ///////////////////////////////////////////
            TV smartTV = new TV();    // 다중상속은 다형성을 적용시킬 수 없으며 다중상속은 지양해야함
            smartTV.PowerOn();
            smartTV.Booting();
            smartTV.AccessInternet();

            ///////////////////////////////////////////
            // 인터페이스로 객체간 결합도 완화에 활용
            ///////////////////////////////////////////
            Bulb bulb = new Bulb();
            Socket socket = new Cable(bulb);

            socket.SwitchOn();
            socket.SwitchOff();

        }
    }
}
