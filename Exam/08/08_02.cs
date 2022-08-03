using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/08/03
 * 이름 : 김태언
 * 내용 : [총정리 문제] 조건문 BMI 계산기
 * 
 * BMI
 *  - BMI(Body Mass Index) 체질량 지수
 *  - 몸무게를 키의 제곱으로 나눈 값
 */
namespace Exam._08
{
    internal class _08_02
    {
        static void Ma1in(string[] args)
        {
            Console.Write("키(cm) 입력 : ");
            double height = double.Parse(Console.ReadLine());
            height /= 100;

            Console.Write("체중(kg) 입력 : ");
            double weight = double.Parse(Console.ReadLine());

            double bmi = weight / (height * height);

            string result;
            if(bmi < 20)
            {
                result = "저체중";
            }
            else if (bmi < 25)
            {
                result = "정상체중";
            }
            else if (bmi < 30)
            {
                result = "경도비만";
            }
            else if (bmi < 40)
            {
                result = "비만";
            }
            else
            {
                result = "고도비만";
            }
            Console.WriteLine("BMI={0:F1}, '{1}'입니다.", bmi, result);
        }
    }
}
