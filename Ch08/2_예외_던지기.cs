using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/26
 * 이름 : 김태언
 * 내용 : 예외던지기(throw) 실습하기 교재 p467
 *
 * 예외던지기(Throw)
 *  - 강제로 에러를 발생시키는 것을 뜻함. 원하지 않은 값이 나올때 사용하기 유리
 * 
 */
namespace Ch08
{
    class Box
    {
        private int width;
        private int height;

        public Box(int width, int height)
        {
            if(width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                // 예외 던지기(예외 강제 발생)
                throw new Exception("크기는 0보다 작을 수 없습니다.");
            }
        }

        public void Area()
        {
            Console.WriteLine("Box 넓이 : " + width * height);
        }
    }
    internal class _2_예외_던지기
    {
        static void Mai1n(string[] args)
        {
            try
            {
                Box box1 = new Box(10, 10);
                box1.Area();


                Box box2 = new Box(-10, -10);
                box2.Area();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
